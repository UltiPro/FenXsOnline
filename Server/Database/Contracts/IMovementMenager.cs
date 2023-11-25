using Classes.Models.Game.Map;

namespace Database.Contracts;

public interface IMovementMenager
{
    Task<PositionResponse> Move(int x, int y);
}
