// RestBook.Application/Services/ReservaService.cs
using RestBook.Application.DTOs;
using RestBook.Application.Interfaces;
using RestBook.Domain.Entities;
using RestBook.Domain.Interfaces;

namespace RestBook.Application.Services
{
    public class ReservaService : IReservaService
    {
        private readonly IReservaRepository _reservaRepository;

        public ReservaService(IReservaRepository reservaRepository)
        {
            _reservaRepository = reservaRepository;
        }

        public async Task<IEnumerable<Reserva>> ObtenerTodasAsync()
        {
            return await _reservaRepository.ObtenerTodasAsync();
        }

        public async Task<Reserva> ObtenerPorIdAsync(Guid id)
        {
            return await _reservaRepository.ObtenerPorIdAsync(id);
        }

        public async Task CrearAsync(ReservaDTO dto)
        {
            var nuevaReserva = new Reserva
            {
                NombreCliente = dto.NombreCliente,
                FechaReserva = dto.FechaReserva,
                NumeroPersonas = dto.NumeroPersonas,
                TelefonoContacto = dto.TelefonoContacto,
                Estado = "Pendiente"
            };

            await _reservaRepository.CrearAsync(nuevaReserva);
        }

        public async Task ActualizarAsync(Guid id, ReservaDTO dto)
        {
            var reservaExistente = await _reservaRepository.ObtenerPorIdAsync(id);
            if (reservaExistente == null) return;

            reservaExistente.NombreCliente = dto.NombreCliente;
            reservaExistente.FechaReserva = dto.FechaReserva;
            reservaExistente.NumeroPersonas = dto.NumeroPersonas;
            reservaExistente.TelefonoContacto = dto.TelefonoContacto;

            await _reservaRepository.ActualizarAsync(reservaExistente);
        }

        public async Task EliminarAsync(Guid id)
        {
            await _reservaRepository.EliminarAsync(id);
        }
    }
}
