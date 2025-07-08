namespace Auth.Application.DTOs
{
    public class UsuarioRegisterDTO
    {
        public string NombreUsuario { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Contrasena { get; set; } = string.Empty;
        public string Rol { get; set; } = "Cliente";
    }
}
