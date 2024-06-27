using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseUser.ResponseEvent;
using Evento_CORE.Entitys;

namespace Evento_APPLICATION.UseCase.UseCaseUser.MapEvent;

public sealed class ListarUserMap : Profile
{
    public ListarUserMap()
    {
        CreateMap<Usuario, ListarUserResponse>();
    }
}
