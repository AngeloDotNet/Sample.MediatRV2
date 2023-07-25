namespace Sample.API.MediatR;

public class DeletePersonCommand : NET6CustomLibrary.MediatR.ICommand<bool>
{
    public int Id { get; set; }

    public DeletePersonCommand(int id)
    {
        Id = id;
    }
}