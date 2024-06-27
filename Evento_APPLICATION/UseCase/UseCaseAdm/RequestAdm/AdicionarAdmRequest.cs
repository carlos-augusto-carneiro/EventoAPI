using Evento_APPLICATION.UseCase.UseCaseAdm.ResponseAdm;
using MediatR;

namespace Evento_APPLICATION.UseCase.UseCaseAdm.RequestAdm;

public sealed record AdicionarAdmRequest(string Name, string Email, string Senha) : IRequest<AdicionarAdmResponse>
{
}
