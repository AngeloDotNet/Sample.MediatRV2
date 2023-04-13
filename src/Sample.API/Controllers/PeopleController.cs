namespace Sample.API.Controllers;

[ApiController]
[Route("api/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class PeopleController : ControllerBase
{
    private readonly IMediator mediator;

    public PeopleController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetPeople()
    {
        var people = await mediator.Send(new GetPeopleListQuery());
        return Ok(people);
    }

    [HttpGet("{id}/{userId}")]
    public async Task<IActionResult> GetPerson(int id, Guid userId)
    {
        var person = await mediator.Send(new GetPersonQuery(id, userId));

        if (person == null)
        {
            return NotFound();
        }

        return Ok(person);
    }

    [HttpPost]
    public async Task<IActionResult> CreatePerson([FromBody] PersonCreateInputModel person)
    {
        var result = await mediator.Send(new CreatePersonCommand(person));
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> UpdatePerson([FromBody] PersonUpdateInputModel person)
    {
        var result = await mediator.Send(new UpdatePersonCommand(person));
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePerson(int id)
    {
        var result = await mediator.Send(new DeletePersonCommand(id));

        if (!result)
        {
            return NotFound();
        }

        return Ok();
    }
}