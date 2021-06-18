using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lab2._1.Models;

namespace Lab2._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmActorsController : ControllerBase
    {
        private readonly Lab2CinemaContext _context;

        public FilmActorsController(Lab2CinemaContext context)
        {
            _context = context;
        }

        // GET: api/FilmActors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FilmActor>>> GetFilmActors()
        {
            return await _context.FilmActors.ToListAsync();
        }

        // GET: api/FilmActors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FilmActor>> GetFilmActor(int id)
        {
            var filmActor = await _context.FilmActors.FindAsync(id);

            if (filmActor == null)
            {
                return NotFound();
            }

            return filmActor;
        }

        // PUT: api/FilmActors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFilmActor(int id, FilmActor filmActor)
        {
            if (id != filmActor.Id)
            {
                return BadRequest();
            }

            _context.Entry(filmActor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilmActorExists(id))
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

        // POST: api/FilmActors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FilmActor>> PostFilmActor(FilmActor filmActor)
        {
            _context.FilmActors.Add(filmActor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFilmActor", new { id = filmActor.Id }, filmActor);
        }

        // DELETE: api/FilmActors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFilmActor(int id)
        {
            var filmActor = await _context.FilmActors.FindAsync(id);
            if (filmActor == null)
            {
                return NotFound();
            }

            _context.FilmActors.Remove(filmActor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FilmActorExists(int id)
        {
            return _context.FilmActors.Any(e => e.Id == id);
        }
    }
}
