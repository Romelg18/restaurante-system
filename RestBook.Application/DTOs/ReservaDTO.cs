// RestBook.Application/DTOs/ReservaDTO.cs
namespace RestBook.Application.DTOs
{
    public class ReservaDTO
    {
        public string NombreCliente { get; set; }
        public DateTime FechaReserva { get; set; }
        public int NumeroPersonas { get; set; }
        public string TelefonoContacto { get; set; }
    }
}
