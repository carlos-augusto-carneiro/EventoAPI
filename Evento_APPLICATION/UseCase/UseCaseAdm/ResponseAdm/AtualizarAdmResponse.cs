namespace Evento_APPLICATION.UseCase.UseCaseAdm.ResponseAdm;

public sealed record AtualizarAdmResponse
{
    public string Name { get; set; }
    public string Senha { get; set; }

    public AtualizarAdmResponse(string name, string senha)
    {
        Name = name;
        Senha = senha;
    }
}
