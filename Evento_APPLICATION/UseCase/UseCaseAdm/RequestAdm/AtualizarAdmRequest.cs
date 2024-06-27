using Evento_APPLICATION.UseCase.UseCaseAdm.ResponseAdm;
using MediatR;

namespace Evento_APPLICATION.UseCase.UseCaseAdm.RequestAdm;

public sealed record AtualizarAdmRequest(Guid Id, string Name, string Senha) : IRequest<AtualizarAdmResponse>
{
}
