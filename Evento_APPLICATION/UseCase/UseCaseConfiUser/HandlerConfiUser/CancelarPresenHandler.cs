using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseConfiUser.RequestConfiUser;
using Evento_APPLICATION.UseCase.UseCaseConfiUser.ResponseConfiUser;
using Evento_CORE.Entitys;
using Evento_CORE.Repositorys;
using MediatR;

namespace Evento_APPLICATION.UseCase.UseCaseConfiUser.HandlerConfiUser;

public sealed class CancelarPresenHandler : IRequestHandler<CancelarPresenRequest, CancelarPresenReponse>
{
    private readonly IMapper _mapper;
    private readonly IConfirmarUsuario _confirmarUsuario;

    public CancelarPresenHandler(IMapper mapper, IConfirmarUsuario confirmarUsuario)
    {
        _mapper = mapper;
        _confirmarUsuario = confirmarUsuario;
    }
    public Task<CancelarPresenReponse> Handle(CancelarPresenRequest request, CancellationToken cancellationToken)
    {
        var mapearRequest = _mapper.Map<ConfirmarUsuario>(request);
        _confirmarUsuario.CancelarPresen(mapearRequest.Id);
        var mapearResponse = _mapper.Map<CancelarPresenReponse>(mapearRequest);

        return Task.FromResult(mapearResponse);
    }
}
