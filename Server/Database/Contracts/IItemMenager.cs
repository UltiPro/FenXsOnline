using Classes.Models.Game.Item;

namespace Database.Contracts;

public interface IItemMenager
{
    Task Get(ItemGet itemGet);
}
