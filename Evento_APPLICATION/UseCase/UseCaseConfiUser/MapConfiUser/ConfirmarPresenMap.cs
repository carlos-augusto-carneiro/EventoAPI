using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseConfiUser.RequestConfiUser;
using Evento_APPLICATION.UseCase.UseCaseConfiUser.ResponseConfiUser;
using Evento_CORE.Entitys;

namespace Evento_APPLICATION.UseCase.UseCaseConfiUser.MapConfiUser;

public sealed class ConfirmarPresenMap : Profile
{
    public ConfirmarPresenMap()
    {
        CreateMap<ConfirmarPresenRequest, ConfirmarUsuario>();
        CreateMap<ConfirmarUsuario, ConfirmarPresenResponse>();
    }
}
