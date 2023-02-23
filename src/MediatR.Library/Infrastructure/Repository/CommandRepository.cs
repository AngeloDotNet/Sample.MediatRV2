using MediatR.Library.Core;
using MediatR.Shared.Entity;
using Microsoft.EntityFrameworkCore;
using Sample.API.Infrastructure.Interfaces;

namespace MediatR.Library.Infrastructure.Repository;

public class CommandRepository<TContext> : Command<PersonEntity>, ICommandRepository where TContext : DbContext
{
    public CommandRepository(TContext dbContext) : base(dbContext)
    {
    }
}