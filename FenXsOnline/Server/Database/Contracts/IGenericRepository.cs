namespace Database.Contracts;

public interface IGenericRepository<T> where T : class
{
    Task<TResult> Get<TResult>(int id);
    Task<TResult> Create<TSource, TResult>(TSource source);
    Task Update<TSource>(int id, TSource source);
    Task Delete(int id);
}
