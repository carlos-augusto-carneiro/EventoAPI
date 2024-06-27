using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseAdm.ResponseAdm;
using Evento_APPLICATION.UseCase.UseCaseUser.RequestEvent;
using Evento_APPLICATION.UseCase.UseCaseUser.ResponseEvent;
using Evento_CORE.Entitys;
using Evento_CORE.Repositorys;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evento_APPLICATION.UseCase.UseCaseUser.HandlerEvent;

public sealed class AdicionarUserHandler : IRequestHandler<AdicionarUserRequest, AdicionarUserResponse>
{
    private readonly IMapper _mapper;
    private readonly IUsuario _usuario;

    public AdicionarUserHandler(IMapper mapper, IUsuario usuario)
    {
        _mapper = mapper;
        _usuario = usuario;
    }

    public Task<AdicionarUserResponse> Handle(AdicionarUserRequest request, CancellationToken cancellationToken)
    {
        var mapearRequest = _mapper.Map<Usuario>(request);
        _usuario.CreatedUser(mapearRequest);
        var mapearResponse = _mapper.Map<AdicionarUserResponse>(mapearRequest);

        return Task.FromResult(mapearResponse);
    }
}
