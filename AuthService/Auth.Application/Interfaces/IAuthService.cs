using Auth.Application.DTOs;

namespace Auth.Application.Interfaces
{
    public interface IAuthService
    {
        Task<string> RegistrarAsync(UsuarioRegisterDTO dto);
        Task<string> LoginAsync(UsuarioLoginDTO dto);
    }
}
