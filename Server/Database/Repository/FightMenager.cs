using Classes.Exceptions;
using Classes.Exceptions.Game;
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
    private readonly Random _random;

    public FightMenager(DatabaseContext _context, IEquipmentMenager _equipmentMenager, IPromotionMenager _promotionMenager)
    {
        this._context = _context;
        this._equipmentMenager = _equipmentMenager;
        this._promotionMenager = _promotionMenager;
        _random = new Random();
    }

    public async Task<FightResponse> FightMob(string accountId, int x, int y)
    {
        var hero = await _context.Heroes.FirstOrDefaultAsync(hero => hero.UserId == accountId && hero.InGame);

        if (hero is null) throw new HeroIsNotInTheGameException();

        if(hero.Dead > DateTime.Now) throw new HeroIsDeadException();

        var mobProvider = await _context.MapMobs
            .FirstOrDefaultAsync(mapMob => mapMob.MapId == hero.MapId && mapMob.X == x && mapMob.Y == y);

        if (mobProvider is null) throw new NotFoundException("Mob", $"({x}, {y})");

        if (mobProvider.Available > DateTime.Now) throw new MobIsDeadException();

        if (Math.Sqrt(Math.Pow(mobProvider.X - hero.X, 2) + Math.Pow(mobProvider.Y - hero.Y, 2)) > 2)
            throw new HeroIsTooFarAwayException();

        var mob = await _context.Mobs.FirstOrDefaultAsync(mob => mob.Id == mobProvider.MobId);

        if (mob is null) throw new NotFoundException("Mob", mobProvider.MobId);

        /* tutaj */

        bool playerAdvantage = hero.Level > mob.Level;
        int levelAdvantage = Math.Abs(hero.Level - mob.Level);

        int mobHP = mob.HealthPoints;

        int dmg;

        double criticalMultiplier = 1.0d;

        int heroArmor = hero.Armor;
        int heroMagicArmor = hero.MagicArmor;

        int mobArmor = mob.Armor;
        int mobMagicArmor = mob.MagicArmor;

        int heroWeight = hero.Weight; // ? 

        int mobWeight = mob.Weight; // ? 

        bool playerTurn = heroWeight <= mobWeight; // ? 

        List<string> logs = new List<string>();

        while (hero.HealthPoints > 0 && mobHP > 0)
        {
            if(playerTurn ? mob.Agility > _random.Next(100) + 1 : hero.Agility > _random.Next(100) + 1)
            {
                logs.Add($"{(playerTurn ? mob.Name : hero.Name)} dodged.");
                playerTurn = !playerTurn;
                continue;
            }
            if (playerTurn ? hero.CriticalChance > _random.Next(100) + 1 : mob.CriticalChance > _random.Next(100) + 1)
                criticalMultiplier = 1.5d;
            dmg = Convert.ToInt32(Math.Floor(
                (playerTurn ? hero.Atack + hero.MagicAtack : mob.Atack + mob.MagicAtack) * criticalMultiplier));
            if (playerTurn) mobHP -= dmg; // tutaj
            else hero.HealthPoints -= dmg; //tutaj
            logs.Add($"{(playerTurn ? hero.Name : mob.Name)} attacked with {dmg}{(criticalMultiplier > 1.0d ? " cricical" : "")} dmg.");
            criticalMultiplier = 1.0d;
            playerTurn = !playerTurn;
        }
        
        /* tutaj */

        var playerWin = hero.HealthPoints > 0;

        if (playerWin) mobProvider.Available = DateTime.Now;//.AddMinutes((mob.Level / 10) + 3);

        await _context.SaveChangesAsync();

        logs.Add($"Winner is {(playerWin ? hero.Name : mob.Name)}.");

        return new FightResponse
        {
            Promotion = playerWin ? await _promotionMenager.Promotion(hero, mob.Level, false) : null,
            Drop = playerWin ? await DropForPlayer(hero, mob) : null,
            Dead = playerWin ? null : await DeadPlayer(hero),
            HelathPoints = hero.HealthPoints,
            Logs = logs
        };
    }

    private async Task<DBHeroEquipment> DropForPlayer(DBHero hero, DBMob mob)
    {
        if (_random.Next(100) + 1 > mob.DropChance) return null;

        var possibleDrops = await _context.MobsDrop.Where(m => m.DBMob == mob).ToListAsync();

        try { return await _equipmentMenager.AddItem(hero.UserId, possibleDrops[_random.Next(possibleDrops.Count)]); }
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
