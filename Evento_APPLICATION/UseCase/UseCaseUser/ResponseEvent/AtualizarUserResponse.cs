namespace Evento_APPLICATION.UseCase.UseCaseUser.ResponseEvent;

public sealed record AtualizarUserResponse
{
    public string Name { get; set; }
    public string Senha { get; set; }

    public AtualizarUserResponse(string name, string senha)
    {
        Name = name;
        Senha = senha;
    }
}
