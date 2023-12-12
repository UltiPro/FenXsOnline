using Classes.Models.Game.Item;

namespace Database.Contracts;

public interface IItemMenager
{
    Task<T> Get<T>(int id) where T : class;
    Task<BaseItem> GetBaseItem<T>(int id) where T : class;
}
