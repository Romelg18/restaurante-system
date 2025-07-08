using Auth.Application.DTOs;
using Auth.Application.Interfaces;
using Auth.Domain.Entities;
using Auth.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Auth.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUsuarioRepository _usuarioRepo;
        private readonly PasswordHasher<Usuario> _passwordHasher;

        public AuthService(IUsuarioRepository usuarioRepo)
        {
            _usuarioRepo = usuarioRepo;
            _passwordHasher = new PasswordHasher<Usuario>();
        }

        public async Task<string> RegistrarAsync(UsuarioRegisterDTO dto)
        {
            var existente = await _usuarioRepo.ObtenerPorCorreoAsync(dto.Correo);
            if (existente != null)
                return "El correo ya está registrado.";

            var usuario = new Usuario
            {
                NombreUsuario = dto.NombreUsuario,
                Correo = dto.Correo,
                Rol = dto.Rol
            };

            usuario.ContrasenaHash = _passwordHasher.HashPassword(usuario, dto.Contrasena);

            await _usuarioRepo.CrearAsync(usuario);
            return "Registro exitoso.";
        }

        public async Task<string> LoginAsync(UsuarioLoginDTO dto)
        {
            var usuario = await _usuarioRepo.ObtenerPorCorreoAsync(dto.Correo);
            if (usuario == null)
                return "Credenciales inválidas.";

            var result = _passwordHasher.VerifyHashedPassword(usuario, usuario.ContrasenaHash, dto.Contrasena);

            if (result == PasswordVerificationResult.Success)
            {
                // Aquí devolveremos un token más adelante
                return "Login exitoso (JWT pendiente)";
            }

            return "Credenciales inválidas.";
        }
    }
}
