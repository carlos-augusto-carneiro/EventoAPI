using Evento_APPLICATION.UseCase.UseCaseConfiUser.ResponseConfiUser;
using MediatR;

namespace Evento_APPLICATION.UseCase.UseCaseConfiUser.RequestConfiUser;

public sealed record AtualizarPresenRequest(Guid Id, string confirmacao) : IRequest<AtualizarPresenResponse>
{
}
