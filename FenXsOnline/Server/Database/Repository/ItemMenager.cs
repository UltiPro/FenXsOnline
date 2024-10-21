using Classes.Exceptions;
using Classes.Models.Game.Item;
using Database.Contracts;

namespace Database.Repository;

public class ItemMenager : IItemMenager
{
    private readonly DatabaseContext _context;

    public ItemMenager(DatabaseContext _context)
    {
        this._context = _context;
    }

    public async Task<T> Get<T>(int id) where T : class
    {
        if (id < 1) throw new BadRequestException("Item id needs to be larger than 0.");

        object? item = await _context.Set<T>().FindAsync(id);

        if (item is null) throw new NotFoundException(typeof(T).Name, id);

        return (T)item;
    }

    public async Task<BaseItem> GetBaseItem<T>(int id) where T : class
    {
        if (id < 1) throw new BadRequestException("Item id needs to be larger than 0.");

        object? item = await _context.Set<T>().FindAsync(id);

        if (item is null) throw new NotFoundException(typeof(T).Name, id);

        return (BaseItem)item;
    }
}
