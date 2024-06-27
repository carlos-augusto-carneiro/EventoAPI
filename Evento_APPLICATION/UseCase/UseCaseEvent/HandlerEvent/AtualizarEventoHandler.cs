using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseEvent.RequestEvent;
using Evento_APPLICATION.UseCase.UseCaseEvent.ResponseEvent;
using Evento_CORE.Entitys;
using Evento_CORE.Repositorys;
using MediatR;

namespace Evento_APPLICATION.UseCase.UseCaseEvent.HandlerEvent;

public sealed class AtualizarEventoHandler : IRequestHandler<AtualizarEventoRequest, AtualizarEventoResponse>
{
    private readonly IMapper _mapper;
    private readonly IEvento _evento;

    public AtualizarEventoHandler(IMapper mapper, IEvento evento)
    {
        _mapper = mapper;
        _evento = evento;
    }
    public Task<AtualizarEventoResponse> Handle(AtualizarEventoRequest request, CancellationToken cancellationToken)
    {
        var mapearRequest = _mapper.Map<Evento>(request);
        _evento.AtualizarEvento(request.Id, mapearRequest);
        var mapearResponse = _mapper.Map<AtualizarEventoResponse>(mapearRequest);

        return Task.FromResult(mapearResponse);
    }
}
