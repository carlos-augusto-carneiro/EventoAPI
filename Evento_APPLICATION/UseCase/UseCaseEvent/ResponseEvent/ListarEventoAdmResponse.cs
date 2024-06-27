using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evento_APPLICATION.UseCase.UseCaseEvent.ResponseEvent;

public sealed record ListarEventoAdmResponse
{
    public string NameEvent { get; private set; }
    public string Descricao { get; private set; }
    public DateTime DataDoEventoInicio { get; private set; }
    public DateTime DataDoEventoFim { get; private set; }
    public int MaxConvidados { get; private set; }
    public float Preco { get; private set; }

    public ListarEventoAdmResponse(string nameEvent, string descricao)
    {
        NameEvent = nameEvent;
        Descricao = descricao;
    }
}
