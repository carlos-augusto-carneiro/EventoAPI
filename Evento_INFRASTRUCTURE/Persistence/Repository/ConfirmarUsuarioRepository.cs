using Evento_CORE.Entitys;
using Evento_CORE.Enum;
using Evento_CORE.Repositorys;
using Microsoft.EntityFrameworkCore;

namespace Evento_INFRASTRUCTURE.Persistence.Repository;

public class ConfirmarUsuarioRepository : IConfirmarUsuario
{
    protected readonly EventoDbContext _context;
    protected readonly IEvento _evento;

    public ConfirmarUsuarioRepository(EventoDbContext context, IEvento evento)
    {
        _context = context;
        _evento = evento;
    }

    public async Task<ConfirmarUsuario> AddAsync(ConfirmarUsuario confirmarUsuario)
    {
        await _context.ConfirmarUsuarios.AddAsync(confirmarUsuario);
        await _context.SaveChangesAsync();

        return confirmarUsuario;
    }

    public async Task<ConfirmarUsuario> AtualizarPresnc(Guid id, ConfirmarUsuario confirmar)
    {
        var confirmacaoExistente = await _context.ConfirmarUsuarios.FindAsync(id);
        if(confirmacaoExistente == null)
        {
            throw new InvalidOperationException("Confirmação não encontrada.");
        }
        confirmacaoExistente.Confirmacao = confirmar.Confirmacao;
        confirmacaoExistente.DataDeConfirmacao = DateTime.Now;

        _context.ConfirmarUsuarios.Update(confirmacaoExistente);
        await _context.SaveChangesAsync();

        return confirmacaoExistente;
    }

    public async Task<bool> CancelarPresen(Guid id)
    {
        var confirmacaoExistente = await _context.ConfirmarUsuarios.FindAsync(id);
        if (confirmacaoExistente == null)
        {
            return false;
        }

        confirmacaoExistente.CancelarPresenca();

        _context.ConfirmarUsuarios.Update(confirmacaoExistente);
        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<ConfirmarUsuario> ConfirmarPresen(Guid idUsuario, Guid idEvento)
    {
        var evento = await _evento.GetEventoByIdAsync(idEvento);
        if (evento == null)
        {
            throw new InvalidOperationException("Evento não encontrado.");
        }

        if (!evento.PodeAdicionarPartici())
        {
            throw new InvalidOperationException("O número máximo de participantes foi alcançado.");
        }

        var confirmacao = new ConfirmarUsuario(idUsuario, idEvento, EnumConfirma.Confirmado);
        evento.AdicionarConfirmacao(confirmacao);

        await AddAsync(confirmacao);
        await _evento.AtualizarEvento(evento.Id, evento);

        return confirmacao;
    }

    public async Task<ConfirmarUsuario?> GetId(Guid id)
    {
        return await _context.ConfirmarUsuarios.Include(x => x.Usuario).Include(x => x.Evento).Include(b => b.Confirmacao).FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<List<ConfirmarUsuario>> GetListEvento(Guid idEvento)
    {
        return await _context.ConfirmarUsuarios.Where(x=>x.IdEvento == idEvento).Include(c => c.Usuario).Include(c => c.Evento).Include(b => b.Confirmacao).ToListAsync();
    }

    public async Task<List<ConfirmarUsuario>> GetListUser(Guid idUser)
    {
        return await _context.ConfirmarUsuarios.Where(x => x.IdUsuario == idUser).Include(c => c.Usuario).Include(c => c.Evento).Include(b=>b.Confirmacao).ToListAsync();
    }
}
