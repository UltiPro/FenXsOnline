using Classes.Enums.Game;

namespace Database.Contracts;

public interface IEquipmentMenager
{
    Task Create(int heroId);
    Task Delete(int heroId);
    Task GetItem(int heroId, ItemType itemType, int itemId);
    Task MoveItem(int heroId, int fromSlotId, int toSlotId);
    Task DestroyItem(int heroId, int itemId);
}
