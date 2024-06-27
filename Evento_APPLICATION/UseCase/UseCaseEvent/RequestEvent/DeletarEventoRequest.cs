using Evento_APPLICATION.UseCase.UseCaseEvent.ResponseEvent;
using MediatR;

namespace Evento_APPLICATION.UseCase.UseCaseEvent.RequestEvent;

public sealed record DeletarEventoRequest(Guid Id) : IRequest<DeletarEventoResponse>
{
}
