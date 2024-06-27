using Evento_CORE.Entitys;

namespace Evento_CORE.Repositorys;

public interface IAdministrador
{
    Task<Administrador> CreatedUser(Administrador administrador);
    Task<bool> DeletedUser(Guid id);
    Task<Administrador> AtulizarAdm(Guid id, Administrador administrador);
    Task<List<Administrador>> ListADM();
    Task<Administrador> GetId(Guid id);
}
