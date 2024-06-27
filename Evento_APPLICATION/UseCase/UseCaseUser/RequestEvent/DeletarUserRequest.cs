using Evento_APPLICATION.UseCase.UseCaseUser.ResponseEvent;
using MediatR;

namespace Evento_APPLICATION.UseCase.UseCaseUser.RequestEvent;

public sealed record DeletarUserRequest(Guid id) : IRequest<DeletarUserResponse>
{
}
