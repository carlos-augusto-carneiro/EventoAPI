using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseUser.RequestEvent;
using Evento_APPLICATION.UseCase.UseCaseUser.ResponseEvent;
using Evento_CORE.Entitys;
using Evento_CORE.Repositorys;
using MediatR;

namespace Evento_APPLICATION.UseCase.UseCaseUser.HandlerEvent;

public sealed class DeletarUserHandler : IRequestHandler<DeletarUserRequest, DeletarUserResponse>
{
    private readonly IMapper _mapper;
    private readonly IUsuario _usuario;

    public DeletarUserHandler(IMapper mapper, IUsuario usuario)
    {
        _mapper = mapper;
        _usuario = usuario;
    }
    public Task<DeletarUserResponse> Handle(DeletarUserRequest request, CancellationToken cancellationToken)
    {
        var mapearRequest = _mapper.Map<Usuario>(request);
        _usuario.DeletedUser(mapearRequest.Id);
        var mapearResponse = _mapper.Map<DeletarUserResponse>(mapearRequest);

        return Task.FromResult(mapearResponse);
    }
}
