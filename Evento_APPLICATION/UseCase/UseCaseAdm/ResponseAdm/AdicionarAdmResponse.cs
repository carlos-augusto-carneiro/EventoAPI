using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evento_APPLICATION.UseCase.UseCaseAdm.ResponseAdm;

public sealed record AdicionarAdmResponse
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }

    public AdicionarAdmResponse(string name, string email, string senha)
    {
        Name = name;
        Email = email;
        Senha = senha;
    }
}
