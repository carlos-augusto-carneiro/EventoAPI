using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseAdm.RequestAdm;
using Evento_APPLICATION.UseCase.UseCaseAdm.ResponseAdm;
using Evento_CORE.Entitys;

namespace Evento_APPLICATION.UseCase.UseCaseAdm.MapAdm;

public sealed class AdicionarAdmMap : Profile
{
    public AdicionarAdmMap()
    {
        CreateMap<AdicionarAdmRequest, Administrador>();
        CreateMap<Administrador, AdicionarAdmResponse>();
    }
}
