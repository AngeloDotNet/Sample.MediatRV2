namespace Sample.API.Handlers;

public class DeletePersonHandler : IRequestHandler<DeletePersonCommand, bool>
{
    private readonly ILogger<DeletePersonHandler> logger;
    private readonly IPeopleService peopleService;

    public DeletePersonHandler(ILogger<DeletePersonHandler> logger, IPeopleService peopleService)
    {
        this.logger = logger;
        this.peopleService = peopleService;
    }

    public async Task<bool> Handle(DeletePersonCommand command, CancellationToken cancellationToken)
    {
        var person = await peopleService.GetPersonAsync(command.Id);

        if (person == null)
        {
            return false;
        }

        await peopleService.DeletePersonAsync(person);
        return true;
    }
}