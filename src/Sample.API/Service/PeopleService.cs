namespace Sample.API.Service;

public class PeopleService : IPeopleService
{
    private readonly IUnitOfWork<PersonEntity, int> unitOfWork;

    public PeopleService(IUnitOfWork<PersonEntity, int> unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public async Task<List<PersonEntity>> GetPeopleAsync()
    {
        var people = await unitOfWork.ReadOnly.GetAllAsync();
        return people;
    }

    public async Task<PersonEntity> GetPersonAsync(int id)
    {
        var person = await unitOfWork.ReadOnly.GetByIdAsync(id);
        return person;
    }

    public async Task CreatePersonAsync(PersonEntity person)
    {
        await unitOfWork.Command.CreateAsync(person);
    }

    public async Task UpdatePersonAsync(PersonEntity person)
    {
        await unitOfWork.Command.UpdateAsync(person);
    }

    public async Task DeletePersonAsync(PersonEntity person)
    {
        await unitOfWork.Command.DeleteAsync(person);
    }
}