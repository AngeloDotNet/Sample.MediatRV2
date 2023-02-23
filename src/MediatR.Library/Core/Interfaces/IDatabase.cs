namespace MediatR.Library.Core.Interfaces;

public interface IDatabase<T> where T : class
{
    Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task<T> GetByIdGuidAsync(Guid id);
}