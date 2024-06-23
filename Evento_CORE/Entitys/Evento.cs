using Evento_CORE.Enum;

namespace Evento_CORE.Entitys;

public class Evento : BaseClass
{
    public string NameEvent { get; private set; }
    public string Descricao { get; private set; }
    public DateTime DataDoEvento { get; private set; }
    public int MaxConvidados { get; private set; }
    public EnumStatus Status { get; private set; }
    public float Preco { get; private set; }

    public Administrador Administrador { get; private set; } = default!;
    public Guid IdAdm { get; private set; }
    public List<Usuario>? Usuario { get; private set; }

    public Evento(string nameEvent, string descricao, DateTime dataDoEvento, int maxConvidados, EnumStatus status, float preco, Guid idAdm)
    {
        NameEvent = nameEvent;
        Descricao = descricao;
        DataDoEvento = dataDoEvento;
        MaxConvidados = maxConvidados;
        Status = EnumStatus.Creado;
        Preco = preco;
        IdAdm = idAdm;
    }

    public void InicioEvento()
    {
        if (Status == EnumStatus.Creado && DataDoEvento == DateTime.Now)
        {
            Status = EnumStatus.Andamento;
        }
    }

    public void FimEvento()
    {
        if (Status == EnumStatus.Andamento)
        {
            Status = EnumStatus.Concluido;
        }
    }

    public void CancelarEvento()
    {
        if (Status == EnumStatus.Creado)
        {
            Status = EnumStatus.Cancelado;
        }
    }

    public void AtualizarEvento(string nameEvent, string descricao, int maxConvidados, int preco)
    {
        NameEvent = nameEvent;
        Descricao = descricao;
        MaxConvidados = maxConvidados;
        Preco = preco;
    }
}
