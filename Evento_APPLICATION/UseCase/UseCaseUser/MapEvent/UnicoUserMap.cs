using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseUser.RequestEvent;
using Evento_APPLICATION.UseCase.UseCaseUser.ResponseEvent;
using Evento_CORE.Entitys;

namespace Evento_APPLICATION.UseCase.UseCaseUser.MapEvent;

public sealed class UnicoUserMap : Profile
{
    public UnicoUserMap()
    {
        CreateMap<UnicoUserRequest, Usuario>();
        CreateMap<Usuario, UnicoUserResponse>();
    }
}
