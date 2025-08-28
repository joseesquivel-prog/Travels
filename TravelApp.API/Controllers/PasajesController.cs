using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelApp.API.Data;
using TravelApp.API.Models;

namespace TravelApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasajesController : ControllerBase
    {
        private readonly TravelContext _context;

        public PasajesController(TravelContext context)
        {
            _context = context;
        }

        // GET: api/Pasajes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pasaje>>> GetPasajes()
        {
            return await _context.Pasajes.ToListAsync();
        }

        // GET: api/Pasajes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pasaje>> GetPasaje(int id)
        {
            var pasaje = await _context.Pasajes.FindAsync(id);

            if (pasaje == null)
            {
                return NotFound();
            }

            return pasaje;
        }

        // POST: api/Pasajes
        [HttpPost]
        public async Task<ActionResult<Pasaje>> PostPasaje(Pasaje pasaje)
        {
            _context.Pasajes.Add(pasaje);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPasaje", new { id = pasaje.IdPasaje }, pasaje);
        }

        // PUT: api/Pasajes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPasaje(int id, Pasaje pasaje)
        {
            if (id != pasaje.IdPasaje)
            {
                return BadRequest();
            }

            _context.Entry(pasaje).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PasajeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Pasajes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePasaje(int id)
        {
            var pasaje = await _context.Pasajes.FindAsync(id);
            if (pasaje == null)
            {
                return NotFound();
            }

            _context.Pasajes.Remove(pasaje);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PasajeExists(int id)
        {
            return _context.Pasajes.Any(e => e.IdPasaje == id);
        }
    }
}