namespace MediatR.Library.Infrastructure.Repository;

public class UnitOfWork<TContext> : IUnitOfWork where TContext : DbContext
{
    private readonly TContext dbContext;
    public IDatabaseRepository ReadOnly { get; }
    public ICommandRepository Command { get; }

    public UnitOfWork(TContext dbContext, IDatabaseRepository databaseRepository, ICommandRepository commandRepository)
    {
        this.dbContext = dbContext;

        ReadOnly = databaseRepository;
        Command = commandRepository;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            dbContext.Dispose();
        }
    }
}