namespace Database.Contracts;

public interface IItemMenager
{
    Task<T> Get<T>(int id) where T : class;
}
