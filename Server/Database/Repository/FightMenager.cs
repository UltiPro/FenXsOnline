using Classes.Exceptions;
using Classes.Exceptions.Game;
using Classes.Exceptions.Game.Hero;
using Classes.Models.Game;
using Classes.Models.Game.Fight;
using Classes.Models.Game.Hero;
using Classes.Models.Game.Mob;
using Database.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Database.Repository;

public class FightMenager : IFightMenager
{
    private readonly DatabaseContext _context;
    private readonly IEquipmentMenager _equipmentMenager;
    private readonly IPromotionMenager _promotionMenager;
    private readonly IQuestMenager _questMenager;
    private readonly Random _random;

    public FightMenager(DatabaseContext _context, IEquipmentMenager _equipmentMenager, IPromotionMenager _promotionMenager, IQuestMenager _questMenager)
    {
        this._context = _context;
        this._equipmentMenager = _equipmentMenager;
        this._promotionMenager = _promotionMenager;
        this._questMenager = _questMenager;
        _random = new Random();
    }

    public async Task<FightResponse> FightMob(string accountId, int x, int y)
    {
        var hero = await _context.Heroes.FirstOrDefaultAsync(hero => hero.UserId == accountId && hero.InGame);

        if (hero is null) throw new HeroIsNotInTheGameException();

        if (hero.Dead > DateTime.Now) throw new HeroIsDeadException();

        var mobProvider = await _context.MapMobs
            .FirstOrDefaultAsync(mapMob => mapMob.MapId == hero.MapId && mapMob.X == x && mapMob.Y == y);

        if (mobProvider is null) throw new NotFoundException("Mob", $"({x}, {y})");

        if (mobProvider.Available > DateTime.Now) throw new MobIsDeadException();

        if (Math.Sqrt(Math.Pow(mobProvider.X - hero.X, 2) + Math.Pow(mobProvider.Y - hero.Y, 2)) > 2)
            throw new HeroIsTooFarAwayException();

        var mob = await _context.Mobs.FirstOrDefaultAsync(mob => mob.Id == mobProvider.MobId);

        if (mob is null) throw new NotFoundException("Mob", mobProvider.MobId);

        List<string> logs = new List<string>();

        bool playerAdvantage = hero.Level >= mob.Level;
        int levelAdvantage = Math.Abs(hero.Level - mob.Level);
        bool levelBonus = levelAdvantage > 3;
        levelAdvantage -= 3;

        int mobHP = mob.HealthPoints;

        int heroAtack = (hero.Attack != 0 && hero.MagicAttack != 0) ? hero.Attack : 10;
        int dmg = 0;
        double criticalMultiplier = 1.0d;

        int heroArmor = hero.Armor;
        int heroMagicArmor = hero.MagicArmor;
        int mobArmor = mob.Armor;
        int mobMagicArmor = mob.MagicArmor;
        int block = 0;
        int magicBlock = 0;

        bool playerTurn = hero.Weight <= mob.Weight;

        while (hero.HealthPoints > 0 && mobHP > 0)
        {
            if (playerTurn ? mob.Agility > _random.Next(100) + 1 : hero.Agility > _random.Next(100) + 1)
            {
                logs.Add($"{(playerTurn ? hero.Name : mob.Name)} attacked but {(playerTurn ? mob.Name : hero.Name)} dodged.");
                playerTurn = !playerTurn;
                continue;
            }
            if (playerTurn ? hero.CriticalChance > _random.Next(100) + 1 : mob.CriticalChance > _random.Next(100) + 1)
                criticalMultiplier = 1.5d;
            dmg = Convert.ToInt32(Math.Floor((playerTurn ? heroAtack + hero.MagicAttack : mob.Attack + mob.MagicAttack) * criticalMultiplier));
            if (levelBonus && playerTurn == playerAdvantage) dmg = dmg + Convert.ToInt32((Convert.ToDouble(dmg) / 10) * levelAdvantage);
            if (playerTurn)
            {
                if (mobArmor > 0 && heroAtack > 0)
                {
                    block = heroAtack <= mobArmor ? heroAtack : (heroAtack - mobArmor);
                    mobArmor -= block;

                }
                if (mobMagicArmor > 0 && hero.MagicAttack > 0)
                {
                    magicBlock = hero.MagicAttack <= mobMagicArmor ? hero.MagicAttack : (hero.MagicAttack - mobMagicArmor);
                    mobMagicArmor -= magicBlock;
                }
            }
            else
            {
                if (heroArmor > 0 && mob.Attack > 0)
                {
                    block = mob.Attack <= heroArmor ? mob.Attack : (mob.Attack - heroArmor);
                    heroArmor -= block;
                }
                if (heroMagicArmor > 0 && mob.MagicAttack > 0)
                {
                    magicBlock = mob.MagicAttack <= heroMagicArmor ? mob.MagicAttack : (mob.MagicAttack - heroMagicArmor);
                    heroMagicArmor -= magicBlock;
                }
            }
            dmg -= (block + magicBlock);
            if (playerTurn) mobHP -= dmg;
            else hero.HealthPoints -= dmg;
            var message = $"{(playerTurn ? hero.Name : mob.Name)} attacked with {dmg}{(criticalMultiplier > 1.0d ? " CRITICAL" : "")} dmg ";
            if (block > 0 || magicBlock > 0)
                message += $"({(playerTurn ? mob.Name : hero.Name)} has blocked {block} damage and {magicBlock} magic damage) ";
            message += $"{(playerTurn ? mob.Name : hero.Name)} left " +
                $"{(playerTurn ? mobHP : hero.HealthPoints)} HP " +
                $"({(playerTurn ? Convert.ToInt32((double)mobHP / mob.HealthPoints * 100) :
                    Convert.ToInt32((double)hero.HealthPoints / hero.MaxHealthPoints * 100))}%).";
            logs.Add(message);
            criticalMultiplier = 1.0d;
            block = magicBlock = 0;
            playerTurn = !playerTurn;
        }

        var playerWin = hero.HealthPoints > 0;

        if (playerWin)
        {
            mobProvider.Available = DateTime.Now.AddMinutes((mob.Level / 10) + 3);
            await _questMenager.Kill(hero, mob.Id);
        }

        await _context.SaveChangesAsync();

        logs.Add($"Winner is {(playerWin ? hero.Name : mob.Name)}.");

        return new FightResponse
        {
            Promotion = playerWin ? _promotionMenager.Promotion(hero, mob.Level, false) : null,
            Drop = playerWin ? await DropForPlayer(hero, mob) : null,
            Dead = playerWin ? null : await DeadPlayer(hero),
            HealthPoints = hero.HealthPoints,
            Logs = logs
        };
    }

    private async Task<DBHeroEquipment> DropForPlayer(DBHero hero, DBMob mob)
    {
        if (_random.Next(100) + 1 > mob.DropChance) return null;

        var possibleDrops = await _context.MobsDrop.Where(m => m.DBMob == mob).ToListAsync();

        try { return await _equipmentMenager.AddItem(hero, possibleDrops[_random.Next(possibleDrops.Count)]); }
        catch { return null; }
    }

    private async Task<DeadResponse> DeadPlayer(DBHero hero)
    {
        hero.HealthPoints = 1;
        hero.MapId = 1;
        hero.X = 21;
        hero.Y = 76;
        hero.Dead = DateTime.Now.AddMinutes((hero.Level / 10) + 1);

        await _context.SaveChangesAsync();

        return new DeadResponse
        {
            MapId = hero.MapId,
            X = hero.X,
            Y = hero.Y,
            Dead = hero.Dead
        };
    }
}
