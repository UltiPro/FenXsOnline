using Classes.Enums.Game;

namespace Database.Contracts;

public interface IItemMenager
{
    public Task Get(ItemType type, int id);
}
