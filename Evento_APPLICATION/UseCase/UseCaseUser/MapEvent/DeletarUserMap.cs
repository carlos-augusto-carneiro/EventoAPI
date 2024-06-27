using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseUser.RequestEvent;
using Evento_APPLICATION.UseCase.UseCaseUser.ResponseEvent;
using Evento_CORE.Entitys;

namespace Evento_APPLICATION.UseCase.UseCaseUser.MapEvent;

public sealed class DeletarUserMap : Profile
{
    public DeletarUserMap()
    {
        CreateMap<DeletarUserRequest, Usuario>();
        CreateMap<Usuario, DeletarUserResponse>();
    }
}
