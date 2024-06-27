﻿using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseEvent.RequestEvent;
using Evento_APPLICATION.UseCase.UseCaseEvent.ResponseEvent;
using Evento_CORE.Entitys;
using Evento_CORE.Repositorys;
using MediatR;

namespace Evento_APPLICATION.UseCase.UseCaseEvent.HandlerEvent;

public sealed class AdicionarEventoHandler : IRequestHandler<AdicionarEventoRequest, AdicionarEventoResponse>
{
    private readonly IMapper _mapper;
    private readonly IEvento _evento;

    public AdicionarEventoHandler(IMapper mapper, IEvento evento)
    {
        _mapper = mapper;
        _evento = evento;
    }

    public Task<AdicionarEventoResponse> Handle(AdicionarEventoRequest request, CancellationToken cancellationToken)
    {
        var mapearRequest = _mapper.Map<Evento>(request);
        _evento.AddEventoAsync(mapearRequest);
        var mapearResponse = _mapper.Map<AdicionarEventoResponse>(mapearRequest);

        return Task.FromResult(mapearResponse);
    }
}
