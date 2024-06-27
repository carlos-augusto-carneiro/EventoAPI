using Evento_CORE.Enum;

namespace Evento_APPLICATION.UseCase.UseCaseUser.ResponseEvent;

public sealed record ListarUserEventoResponse
{
    public string NameEvent { get; private set; }
    public string Descricao { get; private set; }
    public DateTime DataDoEvento { get; private set; }
    public EnumStatus Status { get; private set; }

    public ListarUserEventoResponse(string nameEvent, string descricao, DateTime dataDoEvento, EnumStatus status)
    {
        NameEvent = nameEvent;
        Descricao = descricao;
        DataDoEvento = dataDoEvento;
        Status = status;
    }
}
