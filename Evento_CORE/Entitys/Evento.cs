using Evento_CORE.Enum;

namespace Evento_CORE.Entitys;

public class Evento : BaseClass
{
    public string NameEvent { get; private set; }
    public string Descricao { get; private set; }
    public DateTime DataCriacao { get; private set; }
    public DateTime DataDoEventoInicio { get; private set; }
    public DateTime DataDoEventoFim { get; private set; }
    public int MaxConvidados { get; private set; }
    public EnumStatus Status { get; private set; }
    public float Preco { get; private set; }

    public Administrador Administrador { get; private set; } = default!;
    public Guid IdAdm { get; private set; }
    public List<Usuario>? Usuario { get; private set; }
    public List<ConfirmarUsuario>? Confirmacoes { get; private set; }
    public Evento(string nameEvent, string descricao, DateTime dataDoEventoInicio, DateTime dataDoEventoFim, int maxConvidados, EnumStatus status, float preco, Guid idAdm, DateTime dataCriacao)
    {
        NameEvent = nameEvent;
        Descricao = descricao;
        DataDoEventoInicio = dataDoEventoInicio;
        DataDoEventoFim = dataDoEventoFim;
        MaxConvidados = maxConvidados;
        Status = EnumStatus.Creado;
        Preco = preco;
        DataCriacao = dataCriacao;
        IdAdm = idAdm;
    }

    public void InicioEvento()
    {
        if (Status == EnumStatus.Creado && DataDoEventoInicio <= DateTime.Now && DateTime.Now < DataDoEventoFim)
        {
            Status = EnumStatus.Andamento;
        }
    }

    public void FimEvento()
    {
        if (Status == EnumStatus.Andamento && DateTime.Now >= DataDoEventoFim)
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

    public void AtualizarEvento(string nameEvent, string descricao, DateTime dataDoEventoInicio, DateTime dataDoEventoFim, int maxConvidados, float preco)
    {
        NameEvent = nameEvent;
        Descricao = descricao;
        DataDoEventoInicio = dataDoEventoInicio;
        DataDoEventoFim = dataDoEventoFim;
        MaxConvidados = maxConvidados;
        Preco = preco;
    }

    public bool PodeAdicionarPartici()
    {
        return Confirmacoes?.Count < MaxConvidados;
    }

    public void AdicionarConfirmacao(ConfirmarUsuario confirmacao)
    {
        if (!PodeAdicionarPartici())
        {
            throw new InvalidOperationException("O número máximo de participantes foi alcançado.");
        }

        if (Status == EnumStatus.Concluido || Status == EnumStatus.Cancelado)
        {
            throw new InvalidOperationException("Não é possível adicionar confirmação a um evento concluído ou cancelado.");
        }

        Confirmacoes?.Add(confirmacao);
    }

    public bool EstaEmAndamento()
    {
        return Status == EnumStatus.Andamento;
    }
}

