using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseEvent.RequestEvent;
using Evento_APPLICATION.UseCase.UseCaseEvent.ResponseEvent;
using Evento_CORE.Repositorys;
using MediatR;

namespace Evento_APPLICATION.UseCase.UseCaseEvent.HandlerEvent;

public sealed class ListarEventoHandler : IRequestHandler<ListarEventoRequest, List<ListarEventoResponse>>
{
    private readonly IMapper _mapper;
    private readonly IEvento _evento;

    public ListarEventoHandler(IMapper mapper, IEvento evento)
    {
        _mapper = mapper;
        _evento = evento;
    }
    public Task<List<ListarEventoResponse>> Handle(ListarEventoRequest request, CancellationToken cancellationToken)
    {
        _evento.GetAllEventosAsync();
        var mapearResponse = _mapper.Map<List<ListarEventoResponse>>(request);

        return Task.FromResult(mapearResponse);
    }
}
