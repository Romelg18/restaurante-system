// RestBook.Domain/Interfaces/IReservaRepository.cs
using RestBook.Domain.Entities;

namespace RestBook.Domain.Interfaces
{
    public interface IReservaRepository
    {
        Task<IEnumerable<Reserva>> ObtenerTodasAsync();
        Task<Reserva> ObtenerPorIdAsync(Guid id);
        Task CrearAsync(Reserva reserva);
        Task ActualizarAsync(Reserva reserva);
        Task EliminarAsync(Guid id);
    }
}
