using AutoMapper;
using Classes.Exceptions;
using Database.Contracts;

namespace Database.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;

    public GenericRepository(DatabaseContext _context, IMapper _mapper)
    {
        this._context = _context;
        this._mapper = _mapper;
    }

    public async Task<TResult> Get<TResult>(int id)
    {
        var entity = await GetEntity(id);

        return _mapper.Map<TResult>(entity);
    }

    public async Task<TResult> Create<TSource, TResult>(TSource source)
    {
        var entity = _mapper.Map<T>(source);

        await _context.AddAsync(entity);
        await _context.SaveChangesAsync();

        return _mapper.Map<TResult>(entity);
    }

    public async Task Update<TSource>(int id, TSource source)
    {
        var entity = await GetEntity(id);

        _mapper.Map(entity, source);
        _context.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var entity = await GetEntity(id);

        _context.Remove(entity);
        await _context.SaveChangesAsync();
    }

    private async Task<T> GetEntity(int id)
    {
        var entity = await _context.Set<T>().FindAsync(id);

        if (entity is null) throw new NotFoundException(typeof(T).Name, id);

        return entity;
    }
}
