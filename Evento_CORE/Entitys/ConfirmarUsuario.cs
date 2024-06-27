using Evento_CORE.Enum;

namespace Evento_CORE.Entitys;

public class ConfirmarUsuario : BaseClass
{
    public Guid IdUsuario { get; private set; }
    public Usuario Usuario { get; private set; } = default!;
    public Guid IdEvento { get; private set; }
    public Evento Evento { get; private set; } = default!;
    public EnumConfirma Confirmacao { get; set; }
    public DateTime DataDeConfirmacao { get; set; }

    private ConfirmarUsuario() { }

    public ConfirmarUsuario(Guid idUsuario, Guid idEvento, EnumConfirma confirmacao)
    {
        IdUsuario = idUsuario;
        IdEvento = idEvento;
        Confirmacao = EnumConfirma.EsperandoResposta;
    }

    public void ConfirmarPresenca()
    {
        Confirmacao = EnumConfirma.Confirmado;
        DataDeConfirmacao = DateTime.Now;
    }

    public void NConfirmarPresenca()
    {
        Confirmacao = EnumConfirma.NConfirmado;
        DataDeConfirmacao = DateTime.Now;
    }

    public void CancelarPresenca()
    {
        if (Confirmacao == EnumConfirma.Confirmado)
        {
            Confirmacao = EnumConfirma.NConfirmado;
            DataDeConfirmacao = DateTime.Now;
        }
    }
}
