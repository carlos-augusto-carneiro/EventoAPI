using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseEvent.RequestEvent;
using Evento_APPLICATION.UseCase.UseCaseEvent.ResponseEvent;
using Evento_CORE.Entitys;
using Evento_CORE.Repositorys;
using MediatR;

namespace Evento_APPLICATION.UseCase.UseCaseEvent.HandlerEvent;

public sealed class UnicoEventoHandler : IRequestHandler<UnicoEventoRequest, UnicoEventoResponse>
{
    private readonly IMapper _mapper;
    private readonly IEvento _evento;

    public UnicoEventoHandler(IMapper mapper, IEvento evento)
    {
        _mapper = mapper;
        _evento = evento;
    }

    public Task<UnicoEventoResponse> Handle(UnicoEventoRequest request, CancellationToken cancellationToken)
    {
        var mapearRequest = _mapper.Map<Evento>(request);
        _evento.GetEventoByIdAsync(request.Id);
        var mapearResponse = _mapper.Map<UnicoEventoResponse>(mapearRequest);

        return Task.FromResult(mapearResponse);
    }
}
