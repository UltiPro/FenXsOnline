using Classes.Models.Game.Map;

namespace Database.Contracts;

public interface IMovementMenager
{
    Task<MapPositionResponse> Move(string accountId, int x, int y);
}
