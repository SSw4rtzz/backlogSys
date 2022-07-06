using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backlogSys.Data;
using backlogSys.Models;

namespace backlogSys.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembrosAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MembrosAPIController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MembrosAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MembrosEquipa>>> GetMembros()
        {
          if (_context.Membros == null)
          {
              return NotFound();
          }
            return await _context.Membros.ToListAsync();
        }

        // GET: api/MembrosAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MembrosEquipa>> GetMembrosEquipa(int id)
        {
          if (_context.Membros == null)
          {
              return NotFound();
          }
            var membrosEquipa = await _context.Membros.FindAsync(id);

            if (membrosEquipa == null)
            {
                return NotFound();
            }

            return membrosEquipa;
        }

        // PUT: api/MembrosAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMembrosEquipa(int id, MembrosEquipa membrosEquipa)
        {
            if (id != membrosEquipa.Id)
            {
                return BadRequest();
            }

            _context.Entry(membrosEquipa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MembrosEquipaExists(id))
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

        // POST: api/MembrosAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MembrosEquipa>> PostMembrosEquipa(MembrosEquipa membrosEquipa)
        {
          if (_context.Membros == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Membros'  is null.");
          }
            _context.Membros.Add(membrosEquipa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMembrosEquipa", new { id = membrosEquipa.Id }, membrosEquipa);
        }

        // DELETE: api/MembrosAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMembrosEquipa(int id)
        {
            if (_context.Membros == null)
            {
                return NotFound();
            }
            var membrosEquipa = await _context.Membros.FindAsync(id);
            if (membrosEquipa == null)
            {
                return NotFound();
            }

            _context.Membros.Remove(membrosEquipa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MembrosEquipaExists(int id)
        {
            return (_context.Membros?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
