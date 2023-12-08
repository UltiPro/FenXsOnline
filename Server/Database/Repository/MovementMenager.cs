using Classes.Exceptions;
using Classes.Models.Game;
using Classes.Models.Game.Map;
using Database.Contracts;

namespace Database.Repository;

public class MovementMenager : IMovementMenager
{
    private readonly DatabaseContext _context;
    private readonly IHeroMenager _heroMenager;
    private readonly World _world;

    public MovementMenager(DatabaseContext _context, IHeroMenager _heroMenager)
    {
        this._context = _context;
        this._heroMenager = _heroMenager;
        _world = World.GetInstance();
    }

    public async Task<MapPositionResponse> Move(string accountId, int x, int y)
    {
        if ((x == 0 && y == 0) || (Math.Abs(x) + Math.Abs(y) > 1))
            throw new BadRequestException("The hero can't move on " +
                "both axes at the same time and have to take a 1 step.");

        var hero = await _heroMenager.GetInGameHeroBackend(accountId);

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
