using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseAdm.RequestAdm;
using Evento_APPLICATION.UseCase.UseCaseAdm.ResponseAdm;
using Evento_CORE.Entitys;
using Evento_CORE.Repositorys;
using MediatR;

namespace Evento_APPLICATION.UseCase.UseCaseAdm.HandlerAdm;

public sealed class DeletarAdmHandler : IRequestHandler<DeletarAdmRequest, DeletarAdmResponse>
{
    private readonly IMapper _mapper;
    private readonly IAdministrador _administrador;

    public DeletarAdmHandler(IMapper mapper, IAdministrador administrador)
    {
        _mapper = mapper;
        _administrador = administrador;
    }

    public Task<DeletarAdmResponse> Handle(DeletarAdmRequest request, CancellationToken cancellationToken)
    {
        var mapearRequest = _mapper.Map<Administrador>(request);
        _administrador.DeletedUser(request.id);
        var mapearResponse = _mapper.Map<DeletarAdmResponse>(mapearRequest);

        return Task.FromResult(mapearResponse);
    }
}
