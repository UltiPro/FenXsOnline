using Classes.Models.Game.Map;

namespace Database.Contracts;

public interface IMovementMenager
{
    Task<MapPositionResponse> Move(int x, int y);
}
