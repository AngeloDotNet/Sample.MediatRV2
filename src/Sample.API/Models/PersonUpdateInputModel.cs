namespace Sample.API.Models;

public class PersonUpdateInputModel
{
    public int Id { get; set; }
    public Guid UserId { get; set; }
    public string Cognome { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }

    public PersonUpdateInputModel(int id, Guid userId, string cognome, string nome, string email)
    {
        Id = id;
        UserId = userId;
        Cognome = cognome;
        Nome = nome;
        Email = email;
    }
}