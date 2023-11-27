using Classes.Enums.Game;

namespace Database.Contracts;

public interface IEquipmentMenager
{
    Task Create(int heroId);
    Task Delete(int heroId);
    Task AddItem(string accountId, ItemType itemType, int itemId);
    Task MoveItem(string accountId, int fromSlotId, int toSlotId);
    Task RemoveItem(string accountId, int itemId);
    Task<bool> HasItem(string accountId, ItemType itemType, int itemId);
}
