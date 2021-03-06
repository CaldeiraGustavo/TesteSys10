using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteSys10.Data;
using TesteSys10.Models;

namespace TesteSys10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EscolasController : ControllerBase
    {
        private readonly EducationContext _context;

        public EscolasController(EducationContext context)
        {
            _context = context;
        }

        // GET: api/Escolas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Escola>>> GetEscola()
        {
            return await _context.Escola.ToListAsync();
        }

        // GET: api/Escolas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Escola>> GetEscola(long id)
        {
            var escola = await _context.Escola.FindAsync(id);

            if (escola == null)
            {
                return NotFound();
            }

            return escola;
        }

        // PUT: api/Escolas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEscola(long id, Escola escola)
        {
            if (id != escola.Id)
            {
                return BadRequest();
            }

            _context.Entry(escola).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EscolaExists(id))
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

        // POST: api/Escolas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Escola>> PostEscola(Escola escola)
        {
            _context.Escola.Add(escola);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEscola", new { id = escola.Id }, escola);
        }

        // DELETE: api/Escolas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEscola(long id)
        {
            var escola = await _context.Escola.FindAsync(id);
            if (escola == null)
            {
                return NotFound();
            }

            _context.Escola.Remove(escola);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EscolaExists(long id)
        {
            return _context.Escola.Any(e => e.Id == id);
        }
    }
}
