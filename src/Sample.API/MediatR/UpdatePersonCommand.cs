namespace Sample.API.MediatR;

public class UpdatePersonCommand : NET6CustomLibrary.MediatR.ICommand<PersonEntity>
{
    public int Id { get; set; }
    public Guid UserId { get; set; }
    public string Cognome { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }

    public UpdatePersonCommand(PersonUpdateInputModel inputModel)
    {
        Id = inputModel.Id;
        UserId = inputModel.UserId;
        Cognome = inputModel.Cognome;
        Nome = inputModel.Nome;
        Email = inputModel.Email;
    }
}