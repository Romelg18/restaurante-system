using Microsoft.AspNetCore.Mvc;
using RestBook.Application.DTOs;
using RestBook.Application.Interfaces;
using RestBook.Domain.Entities;

namespace RestBook.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ReservaController : ControllerBase
    {
        private readonly IReservaService _reservaService;

        public ReservaController(IReservaService reservaService)
        {
            _reservaService = reservaService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reserva>>> Get()
        {
            var reservas = await _reservaService.ObtenerTodasAsync();
            return Ok(reservas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Reserva>> Get(Guid id)
        {
            var reserva = await _reservaService.ObtenerPorIdAsync(id);
            if (reserva == null) return NotFound();
            return Ok(reserva);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ReservaDTO dto)
        {
            await _reservaService.CrearAsync(dto);
            return CreatedAtAction(nameof(Get), new { }, dto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(Guid id, [FromBody] ReservaDTO dto)
        {
            await _reservaService.ActualizarAsync(id, dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await _reservaService.EliminarAsync(id);
            return NoContent();
        }
    }
}
