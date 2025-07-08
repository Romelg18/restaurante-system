// RestBook.Application/Interfaces/IReservaService.cs
using RestBook.Application.DTOs;
using RestBook.Domain.Entities;

namespace RestBook.Application.Interfaces
{
    public interface IReservaService
    {
        Task<IEnumerable<Reserva>> ObtenerTodasAsync();
        Task<Reserva> ObtenerPorIdAsync(Guid id);
        Task CrearAsync(ReservaDTO reservaDTO);
        Task ActualizarAsync(Guid id, ReservaDTO reservaDTO);
        Task EliminarAsync(Guid id);
    }
}
