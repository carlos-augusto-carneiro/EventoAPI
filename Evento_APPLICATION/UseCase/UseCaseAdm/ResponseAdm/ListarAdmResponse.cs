namespace Evento_APPLICATION.UseCase.UseCaseAdm.ResponseAdm;

public sealed record ListarAdmResponse
{
    public Guid id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime DataDeCadastro { get; set; }

    public ListarAdmResponse(Guid id, string name, string email, DateTime dataDeCadastro)
    {
        this.id = id;
        Name = name;
        Email = email;
        DataDeCadastro = dataDeCadastro;
    }
}
