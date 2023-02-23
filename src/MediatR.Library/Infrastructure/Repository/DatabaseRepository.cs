using MediatR.Library.Core;
using MediatR.Shared.Entity;
using Microsoft.EntityFrameworkCore;
using Sample.API.Infrastructure.Interfaces;

namespace MediatR.Library.Infrastructure.Repository;

public class DatabaseRepository<TContext> : Database<PersonEntity>, IDatabaseRepository where TContext : DbContext
{
    public DatabaseRepository(TContext dbContext) : base(dbContext)
    {
    }
}