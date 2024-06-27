using Evento_APPLICATION.UseCase.UseCaseEvent.ResponseEvent;
using MediatR;

namespace Evento_APPLICATION.UseCase.UseCaseEvent.RequestEvent;

public sealed record AdicionarEventoRequest(string NameEvent, string Descricao, DateTime DataDoEventoInicio, 
                                            DateTime DataDoEventoFim, int Maxconvidados, float Preco) 
                                            : IRequest<AdicionarEventoResponse>
{
}
