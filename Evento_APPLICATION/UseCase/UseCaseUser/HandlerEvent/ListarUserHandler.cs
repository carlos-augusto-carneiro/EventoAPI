using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseAdm.ResponseAdm;
using Evento_APPLICATION.UseCase.UseCaseUser.RequestEvent;
using Evento_APPLICATION.UseCase.UseCaseUser.ResponseEvent;
using Evento_CORE.Entitys;
using Evento_CORE.Repositorys;
using MediatR;

namespace Evento_APPLICATION.UseCase.UseCaseUser.HandlerEvent;

public sealed class ListarUserHandler : IRequestHandler<ListarUserRequest, List<ListarUserResponse>>
{
    private readonly IMapper _mapper;
    private readonly IUsuario _usuario;

    public ListarUserHandler(IMapper mapper, IUsuario usuario)
    {
        _mapper = mapper;
        _usuario = usuario;
    }
    public Task<List<ListarUserResponse>> Handle(ListarUserRequest request, CancellationToken cancellationToken)
    {
        var listar = _usuario.ListUser();
        var mapearResponse = _mapper.Map<List<ListarUserResponse>>(listar);

        return Task.FromResult(mapearResponse);
    }
}
