using Classes.Models.Game.Item;

namespace Database.Contracts;

public interface IItemMenager
{
    public Task Get(ItemGet itemGet);
}
