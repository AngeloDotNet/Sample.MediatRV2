namespace MediatR.Library.Infrastructure.Repository;

public class CommandRepository<TContext> : Command<PersonEntity>, ICommandRepository where TContext : DbContext
{
    public CommandRepository(TContext dbContext) : base(dbContext)
    {
    }
}