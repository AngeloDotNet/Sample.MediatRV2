namespace Sample.API.Infrastructure.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IDatabaseRepository ReadOnly { get; }
    ICommandRepository Command { get; }
}