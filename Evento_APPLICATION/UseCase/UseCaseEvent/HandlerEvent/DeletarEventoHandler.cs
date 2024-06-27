using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseEvent.RequestEvent;
using Evento_APPLICATION.UseCase.UseCaseEvent.ResponseEvent;
using Evento_CORE.Entitys;
using Evento_CORE.Repositorys;
using MediatR;

namespace Evento_APPLICATION.UseCase.UseCaseEvent.HandlerEvent;

public sealed class DeletarEventoHandler : IRequestHandler<DeletarEventoRequest, DeletarEventoResponse>
{
    private readonly IMapper _mapper;
    private readonly IEvento _evento;

    public DeletarEventoHandler(IMapper mapper, IEvento evento)
    {
        _mapper = mapper;
        _evento = evento;
    }

    public Task<DeletarEventoResponse> Handle(DeletarEventoRequest request, CancellationToken cancellationToken)
    {
        var mapearRequest = _mapper.Map<Evento>(request);
        _evento.DeleteEventoAsync(request.Id);
        var mapearResponse = _mapper.Map<DeletarEventoResponse>(mapearRequest);

        return Task.FromResult(mapearResponse);
    }
}
