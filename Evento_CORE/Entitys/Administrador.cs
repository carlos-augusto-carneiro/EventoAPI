using Evento_CORE.Enum;
using System.Xml.Linq;

namespace Evento_CORE.Entitys;

public class Administrador : BaseClass
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public DateTime DataDeCadastro { get; set; }
    public RoleEnum Role { get; private set; }

    public List<Evento>? Evento { get; set; }

    public Administrador(string name, string email, string senha, DateTime dataDeCadastro, RoleEnum role)
    {
        Name = name;
        Email = email;
        Senha = senha;
        DataDeCadastro = DateTime.Now;
        Role = RoleEnum.Administrador;

    }
    public void AtualizarDados(string name, string senha, string email)
    {
        Name = name;
        Senha = senha;
    }
}
