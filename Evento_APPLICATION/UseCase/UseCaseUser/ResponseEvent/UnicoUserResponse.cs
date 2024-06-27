namespace Evento_APPLICATION.UseCase.UseCaseUser.ResponseEvent;

public sealed record UnicoUserResponse 
{
    public Guid id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime DataDeCadastro { get; set; }

    public UnicoUserResponse(Guid id, string name, string email, DateTime dataDeCadastro)
    {
        this.id = id;
        Name = name;
        Email = email;
        DataDeCadastro = dataDeCadastro;
    }
}
