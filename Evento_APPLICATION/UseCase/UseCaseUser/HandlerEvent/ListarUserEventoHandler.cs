using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseUser.RequestEvent;
using Evento_APPLICATION.UseCase.UseCaseUser.ResponseEvent;
using Evento_CORE.Entitys;
using Evento_CORE.Repositorys;
using MediatR;

namespace Evento_APPLICATION.UseCase.UseCaseUser.HandlerEvent;

public sealed class ListarUserEventoHandler : IRequestHandler<ListarUserEventoRequest, List<ListarUserEventoResponse>>
{
    private readonly IMapper _mapper;
    private readonly IUsuario _usuario;

    public ListarUserEventoHandler(IMapper mapper, IUsuario usuario)
    {
        _mapper = mapper;
        _usuario = usuario;
    }

    public Task<List<ListarUserEventoResponse>> Handle(ListarUserEventoRequest request, CancellationToken cancellationToken)
    {
        var mapearRequest = _mapper.Map<Usuario>(request);
        _usuario.GetListEventoUser(mapearRequest.Id);
        var mapearResponse = _mapper.Map<List<ListarUserEventoResponse>>(mapearRequest);

        return Task.FromResult(mapearResponse);
    }
}
