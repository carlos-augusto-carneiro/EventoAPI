using Evento_APPLICATION.UseCase.UseCaseUser.ResponseEvent;
using MediatR;

namespace Evento_APPLICATION.UseCase.UseCaseUser.RequestEvent;

public sealed record AtualizarUserRequest(Guid Id, string Name, string Senha) : IRequest<AtualizarUserResponse>
{
}
