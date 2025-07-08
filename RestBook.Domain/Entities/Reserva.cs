// RestBook.Domain/Entities/Reserva.cs
namespace RestBook.Domain.Entities
{
    public class Reserva
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string NombreCliente { get; set; }
        public DateTime FechaReserva { get; set; }
        public int NumeroPersonas { get; set; }
        public string TelefonoContacto { get; set; }
        public string Estado { get; set; } = "Pendiente"; // Pendiente, Confirmada, Cancelada
    }
}
