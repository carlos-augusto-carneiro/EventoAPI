using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseConfiUser.RequestConfiUser;
using Evento_APPLICATION.UseCase.UseCaseConfiUser.ResponseConfiUser;
using Evento_CORE.Entitys;

namespace Evento_APPLICATION.UseCase.UseCaseConfiUser.MapConfiUser;

public sealed class CancelarPresenMap : Profile
{
    public CancelarPresenMap()
    {
        CreateMap<CancelarPresenRequest, ConfirmarUsuario>();
        CreateMap<ConfirmarUsuario, CancelarPresenReponse>();
    }
}
