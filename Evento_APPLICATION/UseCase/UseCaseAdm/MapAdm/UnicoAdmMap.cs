using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseAdm.RequestAdm;
using Evento_APPLICATION.UseCase.UseCaseAdm.ResponseAdm;
using Evento_CORE.Entitys;

namespace Evento_APPLICATION.UseCase.UseCaseAdm.MapAdm;

public sealed class UnicoAdmMap : Profile
{
    public UnicoAdmMap()
    {
        CreateMap<UnicoAdmRequest, Administrador>();
        CreateMap<Administrador, UnicoAdmResponse>();
    }
}
