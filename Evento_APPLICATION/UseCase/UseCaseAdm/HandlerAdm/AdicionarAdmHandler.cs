using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseAdm.RequestAdm;
using Evento_APPLICATION.UseCase.UseCaseAdm.ResponseAdm;
using Evento_CORE.Entitys;
using Evento_CORE.Repositorys;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evento_APPLICATION.UseCase.UseCaseAdm.HandlerAdm;

public sealed class AdicionarAdmHandler : IRequestHandler<AdicionarAdmRequest, AdicionarAdmResponse>
{
    private readonly IMapper _mapper;
    private readonly IAdministrador _administrador;

    public AdicionarAdmHandler(IMapper mapper, IAdministrador administrador)
    {
        _mapper = mapper;
        _administrador = administrador;
    }

    public Task<AdicionarAdmResponse> Handle(AdicionarAdmRequest request, CancellationToken cancellationToken)
    {
        var mapearRequest = _mapper.Map<Administrador>(request);
        _administrador.CreatedUser(mapearRequest);
        var mapearResponse = _mapper.Map<AdicionarAdmResponse>(mapearRequest);

        return Task.FromResult(mapearResponse);
    }
}
