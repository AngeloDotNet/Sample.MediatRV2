namespace Sample.API.Handlers;

public class GetPersonHandler : NET6CustomLibrary.MediatR.IQueryHandler<GetPersonQuery, PersonEntity>
{
    private readonly ILogger<GetPersonHandler> logger;
    private readonly IPeopleService peopleService;

    public GetPersonHandler(ILogger<GetPersonHandler> logger, IPeopleService peopleService)
    {
        this.logger = logger;
        this.peopleService = peopleService;
    }

    public async Task<PersonEntity> Handle(GetPersonQuery request, CancellationToken cancellationToken)
    {
        var result = await peopleService.GetPersonAsync(request.Id);

        if (result != null)
        {
            if (result.UserId == request.UserId)
            {
                return result;
            }
        }

        return null;
    }
}