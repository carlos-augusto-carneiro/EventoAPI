using Evento_CORE.Enum;

namespace Evento_APPLICATION.UseCase.UseCaseConfiUser.ResponseConfiUser;

public sealed record AtualizarPresenResponse
{
    public Guid IdUsuario { get; private set; }
    public Guid IdEvento { get; private set; }
    public EnumConfirma Confirmacao { get; set; }
}
