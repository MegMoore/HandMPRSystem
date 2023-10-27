using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HandMPRSystem.Data;
using HandMPRSystem.Models;

namespace HandMPRSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PantographsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PantographsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Pantographs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pantograph>>> GetPantographs()
        {
          if (_context.Pantographs == null)
          {
              return NotFound();
          }
            return await _context.Pantographs.ToListAsync();
        }

        // GET: api/Pantographs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pantograph>> GetPantographs(int id)
        {
          if (_context.Pantographs == null)
          {
              return NotFound();
          }
            var pantographs = await _context.Pantographs.FindAsync(id);

            if (pantographs == null)
            {
                return NotFound();
            }

            return pantographs;
        }

        // PUT: api/Pantographs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPantographs(int id, Pantograph pantographs)
        {
            if (id != pantographs.Id)
            {
                return BadRequest();
            }

            _context.Entry(pantographs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PantographsExists(id))
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

        // POST: api/Pantographs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pantograph>> PostPantographs(Pantograph pantographs)
        {
          if (_context.Pantographs == null)
          {
              return Problem("Entity set 'AppDbContext.Pantographs'  is null.");
          }
            _context.Pantographs.Add(pantographs);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPantographs", new { id = pantographs.Id }, pantographs);
        }

        // DELETE: api/Pantographs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePantographs(int id)
        {
            if (_context.Pantographs == null)
            {
                return NotFound();
            }
            var pantographs = await _context.Pantographs.FindAsync(id);
            if (pantographs == null)
            {
                return NotFound();
            }

            _context.Pantographs.Remove(pantographs);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PantographsExists(int id)
        {
            return (_context.Pantographs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
