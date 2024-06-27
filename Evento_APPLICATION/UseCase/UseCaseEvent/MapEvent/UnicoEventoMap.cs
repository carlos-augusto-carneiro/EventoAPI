using AutoMapper;
using Evento_APPLICATION.UseCase.UseCaseEvent.RequestEvent;
using Evento_APPLICATION.UseCase.UseCaseEvent.ResponseEvent;
using Evento_CORE.Entitys;

namespace Evento_APPLICATION.UseCase.UseCaseEvent.MapEvent;

public sealed class UnicoEventoMap : Profile
{
    public UnicoEventoMap()
    {
        CreateMap<UnicoEventoRequest, Evento>();
        CreateMap<Evento, UnicoEventoResponse>();
    }
}
