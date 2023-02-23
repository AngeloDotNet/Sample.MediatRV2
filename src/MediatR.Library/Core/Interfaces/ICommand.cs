namespace MediatR.Library.Core.Interfaces;

public interface ICommand<T> where T : class
{
    Task CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}