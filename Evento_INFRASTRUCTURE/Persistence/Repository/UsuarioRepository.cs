using Evento_CORE.Entitys;
using Evento_CORE.Repositorys;
using Microsoft.EntityFrameworkCore;

namespace Evento_INFRASTRUCTURE.Persistence.Repository;

public class UsuarioRepository : IUsuario
{

    protected readonly EventoDbContext _context;

    public UsuarioRepository(EventoDbContext context)
    {
        _context = context;
    }

    public async Task<Usuario> AtualizarUser(Guid id, Usuario usuario)
    {
        var user = await GetId(id);
        user.AtualizarDados(usuario.Name, usuario.Senha);
        await _context.SaveChangesAsync();

        return user;
    }

    public async Task<Usuario> CreatedUser(Usuario usuario)
    {
        _context.Usuarios.Add(usuario);
        await _context.SaveChangesAsync();

        return usuario;
    }

    public async Task<bool> DeletedUser(Guid id)
    {
        var buscarId = await GetId(id);

        if (buscarId != null)
        {
            _context.Usuarios.Remove(buscarId);
            await _context.SaveChangesAsync();

            return true;
        }

        return false;
    }

    public async Task<Usuario> GetId(Guid id)
    {
        var usuario = await _context.Usuarios.FirstOrDefaultAsync(e => e.Id == id);
        if (usuario != null)
        {
            return usuario;
        }
        throw new ArgumentException($"Não foi possível encontrar o Usuario com Id {id}");
    }

    public async Task<List<Evento>> GetListEventoUser(Guid idUser)
    {
        var eventos = await _context.Eventos.Where(e => e.Usuario != null && e.Usuario.Any(u => u.Id == idUser)).ToListAsync();

        return eventos;
    }

    public async Task<List<Usuario>> ListUser()
    {
        var usuarios = await _context.Usuarios.ToListAsync();

        return usuarios;
    }
}
