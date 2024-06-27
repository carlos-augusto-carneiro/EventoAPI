using Evento_APPLICATION.UseCase.UseCaseAdm.ResponseAdm;
using MediatR;

namespace Evento_APPLICATION.UseCase.UseCaseAdm.RequestAdm;

public sealed record ListarAdmRequest() : IRequest<List<ListarAdmResponse>>
{
}
