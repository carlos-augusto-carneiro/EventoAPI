using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseEvent.RequestEvent;
using Evento_APPLICATION.UseCase.UseCaseEvent.ResponseEvent;
using Evento_CORE.Entitys;
using Evento_CORE.Repositorys;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evento_APPLICATION.UseCase.UseCaseEvent.HandlerEvent;

public sealed class ListarEventoAdmHandler : IRequestHandler<ListarEventoAdmRequest, ListarEventoAdmResponse>
{
    private readonly IMapper _mapper;
    private readonly IEvento _evento;

    public ListarEventoAdmHandler(IMapper mapper, IEvento evento)
    {
        _mapper = mapper;
        _evento = evento;
    }
    public Task<ListarEventoAdmResponse> Handle(ListarEventoAdmRequest request, CancellationToken cancellationToken)
    {
        var mapearRequest = _mapper.Map<Evento>(request);
        _evento.GetEventosByAdministradorAsync(request.IdAdm);
        var mapearResponse = _mapper.Map<ListarEventoAdmResponse>(mapearRequest);

        return Task.FromResult(mapearResponse);
    }
}
