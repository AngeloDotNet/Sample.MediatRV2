using MediatR.Library.Core.Interfaces;
using MediatR.Shared.Entity;

namespace Sample.API.Infrastructure.Interfaces;

public interface IDatabaseRepository : IDatabase<PersonEntity>
{
    // Add your custom code here
}