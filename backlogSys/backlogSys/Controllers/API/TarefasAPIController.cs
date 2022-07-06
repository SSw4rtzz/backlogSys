using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backlogSys.Data;
using backlogSys.Models;

namespace backlogSys
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TarefasAPIController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TarefasAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tarefas>>> GetTarefas()
        {
          if (_context.Tarefas == null)
          {
              return NotFound();
          }
            return await _context.Tarefas.ToListAsync();
        }

        // GET: api/TarefasAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tarefas>> GetTarefas(int id)
        {
          if (_context.Tarefas == null)
          {
              return NotFound();
          }
            var tarefas = await _context.Tarefas.FindAsync(id);

            if (tarefas == null)
            {
                return NotFound();
            }

            return tarefas;
        }

        // PUT: api/TarefasAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTarefas(int id, Tarefas tarefas)
        {
            if (id != tarefas.Id)
            {
                return BadRequest();
            }

            _context.Entry(tarefas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TarefasExists(id))
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

        // POST: api/TarefasAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tarefas>> PostTarefas(Tarefas tarefas)
        {
          if (_context.Tarefas == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Tarefas'  is null.");
          }
            _context.Tarefas.Add(tarefas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTarefas", new { id = tarefas.Id }, tarefas);
        }

        // DELETE: api/TarefasAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTarefas(int id)
        {
            if (_context.Tarefas == null)
            {
                return NotFound();
            }
            var tarefas = await _context.Tarefas.FindAsync(id);
            if (tarefas == null)
            {
                return NotFound();
            }

            _context.Tarefas.Remove(tarefas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TarefasExists(int id)
        {
            return (_context.Tarefas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
