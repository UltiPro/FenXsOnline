using Classes.Models.Game.Item;
using Classes.Models.Game.Map;

namespace Database.Contracts;

public interface IMovementMenager
{
    Task<PositionResponse> Move(ItemGet itemGet);
}
