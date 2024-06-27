using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseAdm.RequestAdm;
using Evento_APPLICATION.UseCase.UseCaseAdm.ResponseAdm;
using Evento_CORE.Entitys;
using Evento_CORE.Repositorys;
using MediatR;

namespace Evento_APPLICATION.UseCase.UseCaseAdm.HandlerAdm;

public sealed class AtualizarAdmHandler : IRequestHandler<AtualizarAdmRequest, AtualizarAdmResponse>
{
    private readonly IMapper _mapper;
    private readonly IAdministrador _administrador;


    public AtualizarAdmHandler(IMapper mapper, IAdministrador administrador)
    {
        _mapper = mapper;
        _administrador = administrador;
    }

    public Task<AtualizarAdmResponse> Handle(AtualizarAdmRequest request, CancellationToken cancellationToken)
    {
        var mapearRequest = _mapper.Map<Administrador>(request);
        _administrador.AtulizarAdm(request.Id,mapearRequest);
        var mapearResponse = _mapper.Map<AtualizarAdmResponse>(mapearRequest);

        return Task.FromResult(mapearResponse);
    }
}
