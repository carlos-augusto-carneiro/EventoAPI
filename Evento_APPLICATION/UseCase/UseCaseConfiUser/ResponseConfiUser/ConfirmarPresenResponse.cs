using Evento_CORE.Entitys;
using Evento_CORE.Enum;

namespace Evento_APPLICATION.UseCase.UseCaseConfiUser.ResponseConfiUser;

public sealed record ConfirmarPresenResponse
{
    public Guid IdUsuario { get; private set; }
    public Guid IdEvento { get; private set; }
    public EnumConfirma Confirmacao { get; set; }
}
