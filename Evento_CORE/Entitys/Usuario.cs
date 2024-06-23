using Evento_CORE.Enum;

namespace Evento_CORE.Entitys;

public class Usuario : BaseClass
{
    public string Name { get; private set; }
    public string Senha { get; private set; }
    public string Email { get; private set; }
    public DateTime DataDeRegistro { get; private set; }
    public RoleEnum Role { get; private set; }


    public Evento? Evento { get; private set; }
    public Guid IdEvento { get; private set; }

    public Usuario(string name, string senha, string email, DateTime dataDeRegistro, Guid idEvento, RoleEnum role)
    {
        Name = name;
        Senha = senha;
        Email = email;
        DataDeRegistro = DateTime.Now;
        Role = RoleEnum.Usuario;
        IdEvento = idEvento;
    }
    public void AtualizarDados(string name, string senha, string email)
    {
        Name = name;
        Senha = senha;
    }

}
