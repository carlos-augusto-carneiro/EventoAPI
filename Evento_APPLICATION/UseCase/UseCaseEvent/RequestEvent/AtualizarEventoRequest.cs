using Evento_APPLICATION.UseCase.UseCaseEvent.ResponseEvent;
using MediatR;

namespace Evento_APPLICATION.UseCase.UseCaseEvent.RequestEvent;

public sealed record AtualizarEventoRequest(Guid Id,string NameEvent, string Descricao, DateTime DataDoEventoInicio,
                                            DateTime DataDoEventoFim, int Maxconvidados, float Preco) : IRequest<AtualizarEventoResponse>
{
}
