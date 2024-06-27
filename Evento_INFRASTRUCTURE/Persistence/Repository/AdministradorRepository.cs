using Evento_CORE.Entitys;
using Evento_CORE.Repositorys;
using Microsoft.EntityFrameworkCore;

namespace Evento_INFRASTRUCTURE.Persistence.Repository;

public class AdministradorRepository : IAdministrador
{

    protected readonly EventoDbContext _context;

    public AdministradorRepository(EventoDbContext context)
    {
        _context = context;
    }

    public async Task<Administrador> AtulizarAdm(Guid id, Administrador administrador)
    {
        var adm = await GetId(id);
        adm.AtualizarDados(administrador.Name, administrador.Senha);
        await _context.SaveChangesAsync();

        return adm;
    }

    public async Task<Administrador> CreatedUser(Administrador administrador)
    {
        _context.Administradors.Add(administrador);
        await _context.SaveChangesAsync();

        return administrador;
    }

    public async Task<bool> DeletedUser(Guid id)
    {
        var buscarId = await GetId(id);

        if (buscarId != null)
        {
            _context.Administradors.Remove(buscarId);
            _context.SaveChanges();

            return true;
        }
        return false;
    }

    public async Task<Administrador> GetId(Guid id)
    {
        var adm = await _context.Administradors.FirstOrDefaultAsync(e => e.Id == id);
        if (adm == null)
        {
            throw new ArgumentException($"Não foi possível encontrar o Administrador com Id {id}");
        }
        return adm;
    }


    public async Task<List<Administrador>> ListADM()
    {
        List<Administrador> todosAdms = await _context.Administradors.ToListAsync();

        return todosAdms;
    }
}
