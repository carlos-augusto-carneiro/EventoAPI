using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseConfiUser.RequestConfiUser;
using Evento_APPLICATION.UseCase.UseCaseConfiUser.ResponseConfiUser;
using Evento_CORE.Repositorys;
using MediatR;

namespace Evento_APPLICATION.UseCase.UseCaseConfiUser.HandlerConfiUser;

public sealed class AtualizarPresenHandler : IRequestHandler<AtualizarPresenRequest, AtualizarPresenResponse>
{
    private readonly IMapper _mapper;
    private readonly IConfirmarUsuario _confirmarUsuario;

    public AtualizarPresenHandler(IMapper mapper, IConfirmarUsuario confirmarUsuario)
    {
        _mapper = mapper;
        _confirmarUsuario = confirmarUsuario;
    }
    public Task<AtualizarPresenResponse> Handle(AtualizarPresenRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
