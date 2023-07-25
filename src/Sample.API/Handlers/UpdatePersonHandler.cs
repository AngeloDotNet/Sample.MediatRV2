namespace Sample.API.Handlers;

public class UpdatePersonHandler : NET6CustomLibrary.MediatR.ICommandHandler<UpdatePersonCommand, PersonEntity>
{
    private readonly ILogger<UpdatePersonHandler> logger;
    private readonly IPeopleService peopleService;
    private readonly IMapper mapper;

    public UpdatePersonHandler(ILogger<UpdatePersonHandler> logger, IPeopleService peopleService, IMapper mapper)
    {
        this.logger = logger;
        this.peopleService = peopleService;
        this.mapper = mapper;
    }

    public async Task<PersonEntity> Handle(UpdatePersonCommand command, CancellationToken cancellationToken)
    {
        var input = mapper.Map<PersonEntity>(command);

        await peopleService.UpdatePersonAsync(input);

        var response = new PersonEntity()
        {
            Id = input.Id,
            UserId = input.UserId,
            Cognome = input.Cognome,
            Nome = input.Nome,
            Email = input.Email
        };

        return response;
    }
}