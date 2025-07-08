using Auth.Domain.Entities;

namespace Auth.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario?> ObtenerPorCorreoAsync(string correo);
        Task CrearAsync(Usuario usuario);
    }
}
