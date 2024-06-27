using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseConfiUser.RequestConfiUser;
using Evento_APPLICATION.UseCase.UseCaseConfiUser.ResponseConfiUser;
using Evento_CORE.Entitys;
using Evento_CORE.Repositorys;
using MediatR;

namespace Evento_APPLICATION.UseCase.UseCaseConfiUser.HandlerConfiUser;

public sealed class ConfirmarPresenHandler : IRequestHandler<ConfirmarPresenRequest, ConfirmarPresenResponse>
{
    private readonly IMapper _mapper;
    private readonly IConfirmarUsuario _confirmarUsuario;

    public ConfirmarPresenHandler(IMapper mapper, IConfirmarUsuario confirmarUsuario)
    {
        _mapper = mapper;
        _confirmarUsuario = confirmarUsuario;
    }

    public Task<ConfirmarPresenResponse> Handle(ConfirmarPresenRequest request, CancellationToken cancellationToken)
    {
        var mapearRequest = _mapper.Map<ConfirmarUsuario>(request);
        _confirmarUsuario.ConfirmarPresen(mapearRequest.IdUsuario, mapearRequest.IdEvento);
        var mapearResponse = _mapper.Map<ConfirmarPresenResponse>(mapearRequest);

        return Task.FromResult(mapearResponse);
    }
}
