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
    public class QuiltsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public QuiltsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Quilts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Quilt>>> GetQuilt()
        {
          if (_context.Quilts == null)
          {
              return NotFound();
          }
            return await _context.Quilts.ToListAsync();
        }

        // GET: api/Quilts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Quilt>> GetQuilt(int id)
        {
          if (_context.Quilts == null)
          {
              return NotFound();
          }
            var quilt = await _context.Quilts.FindAsync(id);

            if (quilt == null)
            {
                return NotFound();
            }

            return quilt;
        }

        // PUT: api/Quilts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuilt(int id, Quilt quilt)
        {
            if (id != quilt.Id)
            {
                return BadRequest();
            }

            _context.Entry(quilt).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuiltExists(id))
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

        // POST: api/Quilts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Quilt>> PostQuilt(Quilt quilt)
        {
          if (_context.Quilts == null)
          {
              return Problem("Entity set 'AppDbContext.Quilt'  is null.");
          }
            _context.Quilts.Add(quilt);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuilt", new { id = quilt.Id }, quilt);
        }

        // DELETE: api/Quilts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuilt(int id)
        {
            if (_context.Quilts == null)
            {
                return NotFound();
            }
            var quilt = await _context.Quilts.FindAsync(id);
            if (quilt == null)
            {
                return NotFound();
            }

            _context.Quilts.Remove(quilt);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool QuiltExists(int id)
        {
            return (_context.Quilts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
