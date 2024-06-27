using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseEvent.RequestEvent;
using Evento_APPLICATION.UseCase.UseCaseEvent.ResponseEvent;
using Evento_CORE.Entitys;

namespace Evento_APPLICATION.UseCase.UseCaseEvent.MapEvent;

public sealed class DeletarEventoMap : Profile
{
    public DeletarEventoMap()
    {
        CreateMap<DeletarEventoRequest, Evento>();
        CreateMap<Evento, DeletarEventoResponse>();
    }
}
