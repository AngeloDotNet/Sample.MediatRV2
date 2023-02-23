namespace MediatR.Library.Core.Interfaces;

public interface IDatabase<TEntity, TKey> where TEntity : class, IEntity<TKey>, new()
{
    Task<List<TEntity>> GetAllAsync();
    Task<TEntity> GetByIdAsync(TKey id);
}