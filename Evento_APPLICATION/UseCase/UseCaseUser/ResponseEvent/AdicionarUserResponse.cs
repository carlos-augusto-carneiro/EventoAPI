namespace Evento_APPLICATION.UseCase.UseCaseUser.ResponseEvent;

public sealed record AdicionarUserResponse
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }

    public AdicionarUserResponse(string name, string email, string senha)
    {
        Name = name;
        Email = email;
        Senha = senha;
    }
}
