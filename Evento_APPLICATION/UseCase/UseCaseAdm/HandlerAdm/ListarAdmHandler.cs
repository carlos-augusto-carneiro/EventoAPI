using AutoMapper;
using Azure;
using Evento_APPLICATION.UseCase.UseCaseAdm.RequestAdm;
using Evento_APPLICATION.UseCase.UseCaseAdm.ResponseAdm;
using Evento_CORE.Entitys;
using Evento_CORE.Repositorys;
using MediatR;

namespace Evento_APPLICATION.UseCase.UseCaseAdm.HandlerAdm;

public sealed class ListarAdmHandler : IRequestHandler<ListarAdmRequest, List<ListarAdmResponse>>
{
    private readonly IMapper _mapper;
    private readonly IAdministrador _administrador;

    public ListarAdmHandler(IMapper mapper, IAdministrador administrador)
    {
        _mapper = mapper;
        _administrador = administrador;
    }

    public Task<List<ListarAdmResponse>> Handle(ListarAdmRequest request, CancellationToken cancellationToken)
    {
        var listar = _administrador.ListADM();
        var mapearResponse = _mapper.Map<List<ListarAdmResponse>>(listar);

        return Task.FromResult(mapearResponse);
    }
}
