using Evento_CORE.Entitys;
using Evento_CORE.Repositorys;
using Microsoft.EntityFrameworkCore;

namespace Evento_INFRASTRUCTURE.Persistence.Repository;

public class EventoRepository : IEvento
{

    protected readonly EventoDbContext _context;

    public EventoRepository(EventoDbContext context)
    {
        _context = context;
    }
    public async Task<Evento> AddEventoAsync(Evento evento)
    {
        _context.Eventos.Add(evento);
        evento.InicioEvento();
        await _context.SaveChangesAsync();
        return evento;
    }

    public async Task<Evento> AtualizarEvento(Guid id, Evento evento)
    {
        var atualizarEvento = await GetEventoByIdAsync(id);
        atualizarEvento.AtualizarEvento(evento.NameEvent, evento.Descricao, evento.DataDoEventoInicio, evento.DataDoEventoFim, evento.MaxConvidados, evento.Preco);
        await _context.SaveChangesAsync();

        return atualizarEvento;
    }

    public async Task<bool> DeleteEventoAsync(Guid id)
    {
        var buscarId = await GetEventoByIdAsync(id);

        if (buscarId != null)
        {
            _context.Eventos.Remove(buscarId);
            await _context.SaveChangesAsync();

            return true;
        }
        return false;
    }

    public async Task<List<Evento>> GetAllEventosAsync()
    {
        List<Evento> eventos = await _context.Eventos.ToListAsync();

        return eventos;
    }

    public async Task<Evento> GetEventoByIdAsync(Guid id)
    {
        var evento = await _context.Eventos.FirstOrDefaultAsync(e => e.Id == id);
        if (evento != null)
        {
            return evento;
        }
        throw new ArgumentException($"Não foi possível encontrar o Evento com Id {id}");
    }

    public async Task<List<Evento>> GetEventosByAdministradorAsync(Guid administradorId)
    {
        var eventos = await _context.Eventos.Where(e => e.IdAdm == administradorId).ToListAsync();

        return eventos;
    }
}
