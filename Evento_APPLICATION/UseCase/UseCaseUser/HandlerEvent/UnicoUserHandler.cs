using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseUser.RequestEvent;
using Evento_APPLICATION.UseCase.UseCaseUser.ResponseEvent;
using Evento_CORE.Entitys;
using Evento_CORE.Repositorys;
using MediatR;

namespace Evento_APPLICATION.UseCase.UseCaseUser.HandlerEvent;

public sealed class UnicoUserHandler : IRequestHandler<UnicoUserRequest, UnicoUserResponse>
{
    private readonly IMapper _mapper;
    private readonly IUsuario _usuario;

    public UnicoUserHandler(IMapper mapper, IUsuario usuario)
    {
        _mapper = mapper;
        _usuario = usuario;
    }

    public Task<UnicoUserResponse> Handle(UnicoUserRequest request, CancellationToken cancellationToken)
    {
        var mapearRequest = _mapper.Map<Usuario>(request);
        _usuario.GetId(request.Id);
        var mapearResponse = _mapper.Map<UnicoUserResponse>(mapearRequest);

        return Task.FromResult(mapearResponse);
    }
}
