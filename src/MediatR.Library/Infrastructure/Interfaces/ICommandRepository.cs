using MediatR.Library.Core.Interfaces;
using MediatR.Shared.Entity;

namespace Sample.API.Infrastructure.Interfaces;

public interface ICommandRepository : ICommand<PersonEntity>
{
    // Add your custom code here
}