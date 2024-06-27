using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseAdm.ResponseAdm;
using Evento_APPLICATION.UseCase.UseCaseUser.RequestEvent;
using Evento_APPLICATION.UseCase.UseCaseUser.ResponseEvent;
using Evento_CORE.Entitys;
using Evento_CORE.Repositorys;
using MediatR;

namespace Evento_APPLICATION.UseCase.UseCaseUser.HandlerEvent;

public sealed class AtualizarUserHandler : IRequestHandler<AtualizarUserRequest, AtualizarUserResponse>
{
    private readonly IMapper _mapper;
    private readonly IUsuario _usuario;

    public AtualizarUserHandler(IMapper mapper, IUsuario usuario)
    {
        _mapper = mapper;
        _usuario = usuario;
    }

    public Task<AtualizarUserResponse> Handle(AtualizarUserRequest request, CancellationToken cancellationToken)
    {
        var mapearRequest = _mapper.Map<Usuario>(request);
        _usuario.AtualizarUser(request.Id, mapearRequest);
        var mapearResponse = _mapper.Map<AtualizarUserResponse>(mapearRequest);

        return Task.FromResult(mapearResponse);
    }
}
