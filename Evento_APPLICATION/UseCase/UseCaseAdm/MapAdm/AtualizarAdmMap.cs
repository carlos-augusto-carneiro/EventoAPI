using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseAdm.RequestAdm;
using Evento_APPLICATION.UseCase.UseCaseAdm.ResponseAdm;
using Evento_CORE.Entitys;

namespace Evento_APPLICATION.UseCase.UseCaseAdm.MapAdm;

public sealed class AtualizarAdmMap : Profile
{
    public AtualizarAdmMap()
    {
        CreateMap<AtualizarAdmRequest, Administrador>();
        CreateMap<Administrador, AtualizarAdmResponse>();
    }
}
