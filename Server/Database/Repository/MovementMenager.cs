using Classes.Exceptions;
using Classes.Exceptions.Game;
using Classes.Models.Game;
using Classes.Models.Game.Map;
using Database.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Database.Repository;

public class MovementMenager : IMovementMenager
{
    private readonly DatabaseContext _context;
    private readonly World _world = World.GetInstance();;

    public MovementMenager(DatabaseContext _context)
    {
        this._context = _context;
    }

    public async Task<MapPositionResponse> Move(string accountId, int x, int y)
    {
        if ((x == 0 && y == 0) || (Math.Abs(x) + Math.Abs(y) > 1))
            throw new BadRequestException("The hero can't move on " +
                "both axes at the same time and have to take a 1 step.");

        var hero = await _context.Heroes.FirstOrDefaultAsync(hero => hero.UserId == accountId && hero.InGame == true);

        if (hero is null) throw new HeroIsNotInTheGameException();

        if (hero.Dead > DateTime.Now) throw new HeroIsDeadException();

        var tempX = hero.X + x;
        var tempY = hero.Y + y;

        try
        {
            if (!_world.Maps[hero.MapId].Fields[tempY, tempX]
                || await _context.MapMobs.AnyAsync(mapMob => mapMob.MapId == hero.MapId
                && mapMob.Available < DateTime.Now && mapMob.X == tempX && mapMob.Y == tempY)) return null;

            hero.X = tempX;
            hero.Y = tempY;

            var door = _world.Maps[hero.MapId].Doors?.FirstOrDefault(door => door.X == hero.X && door.Y == hero.Y);

            if (door != null)
            {
                hero.MapId = door.ToMapId;
                hero.X = door.ToX;
                hero.Y = door.ToY;
            }

            await _context.SaveChangesAsync();

            return new MapPositionResponse
            {
                MapId = hero.MapId,
                X = hero.X,
                Y = hero.Y
            };
        }
        catch
        {
            return null;
        }
    }
}
