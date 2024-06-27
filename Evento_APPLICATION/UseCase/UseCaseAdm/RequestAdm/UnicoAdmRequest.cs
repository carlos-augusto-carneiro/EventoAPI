using Evento_APPLICATION.UseCase.UseCaseAdm.ResponseAdm;
using MediatR;

namespace Evento_APPLICATION.UseCase.UseCaseAdm.RequestAdm;

public sealed record UnicoAdmRequest(Guid Id) : IRequest<UnicoAdmResponse>
{
}
