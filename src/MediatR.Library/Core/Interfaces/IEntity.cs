namespace MediatR.Library.Core.Interfaces;

public interface IEntity<TKey>
{
    TKey Id { get; set; }
}