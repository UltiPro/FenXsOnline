using Classes.Exceptions;
using Classes.Exceptions.Game;
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
    private readonly Random _random;

    public FightMenager(DatabaseContext _context, IEquipmentMenager _equipmentMenager)
    {
        this._context = _context;
        this._equipmentMenager = _equipmentMenager;
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

        int heroWeight = hero.Weight; // to
        int mobWeight = mob.Weight; // to

        int mobHP = mob.HealthPoints;

        int levelDifference = hero.Level = mob.Level; // to

        bool playerTurn = heroWeight <= mobWeight; // to

        List<string> logs = new List<string>(); // to

        while (hero.HealthPoints > 0 && mobHP > 0)
        { 
            if(playerTurn) mobHP -= (hero.Atack + hero.MagicAtack);
            else hero.HealthPoints -= (mob.Atack + mob.MagicAtack);
            playerTurn = !playerTurn;
        }

        var playerWin = hero.HealthPoints > 0;

        if (!playerWin) DeadPlayer(hero);
        else mobProvider.Available = DateTime.Now.AddMinutes((mob.Level / 10) + 3);

        await _context.SaveChangesAsync();

        return new FightResponse
        {
            PlayerWin = playerWin,
            HelathPoints = hero.HealthPoints,
            Drop = playerWin ? await DropForPlayer(hero, mob) : null,
            MapId = hero.MapId,
            X = hero.X,
            Y = hero.Y,
            Dead = playerWin ? null : hero.Dead,
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

    private void DeadPlayer(DBHero hero)
    {
        hero.MapId = 1;
        hero.X = 21;
        hero.Y = 76;
        hero.HealthPoints = 1;
        hero.Dead = DateTime.Now.AddMinutes((hero.Level / 10) + 1);
    }
}
