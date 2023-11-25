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
    private readonly World _world;

    public MovementMenager(DatabaseContext _context)
    {
        this._context = _context;
        _world = World.GetInstance();
    }

    public async Task<MapPositionResponse> Move(string accountId, int x, int y)
    {
        if ((x == 0 && y == 0) || (Math.Abs(x) + Math.Abs(y) > 1))
            throw new BadRequestException("The hero can't move on " +
                "both axes at the same time and have to take a 1 step.");

        var hero = await _context.Heroes.FirstOrDefaultAsync(hero => hero.InGame && hero.UserId == accountId);

        if (hero is null) throw new HeroIsNotInTheGameException();

        try
        {
            if (!_world.Maps[hero.MapId].Fields[hero.Y + y, hero.X + x]) return null;

            hero.X += x;
            hero.Y += y;

            var door = _world.Maps[hero.MapId].Doors?.FirstOrDefault(door => door.FromX == hero.X && door.FromY == hero.Y);

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
