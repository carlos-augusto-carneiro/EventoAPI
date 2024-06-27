using Evento_CORE.Entitys;

namespace Evento_CORE.Repositorys;

public interface IEvento
{
    Task<Evento> GetEventoByIdAsync(Guid id);
    Task<List<Evento>> GetAllEventosAsync();
    Task<Evento> AddEventoAsync(Evento evento);
    Task<bool> DeleteEventoAsync(Guid id);
    Task<Evento> AtualizarEvento(Guid id, Evento evento);
    Task<List<Evento>> GetEventosByAdministradorAsync(Guid administradorId);

}
