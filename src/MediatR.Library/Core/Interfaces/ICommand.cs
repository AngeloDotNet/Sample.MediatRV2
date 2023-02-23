namespace MediatR.Library.Core.Interfaces;

public interface ICommand<TEntity, TKey> where TEntity : class, IEntity<TKey>, new()
{
    Task CreateAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
}