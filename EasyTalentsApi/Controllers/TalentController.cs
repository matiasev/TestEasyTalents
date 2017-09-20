using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;
using EasyTalentsData.Data;
using EasyTalentsData.Models;

namespace EasyTalentsApi.Controllers
{
    [EnableCors("MyAppPolicy")]
    [Produces("application/json")]
    [Route("api/Talent")]
    public class TalentController : Controller
    {
        private readonly EasyTalentsContext _context;

        public TalentController(EasyTalentsContext context)
        {
            _context = context;
        }

        // GET: api/Talent
        [HttpGet]
        public IEnumerable<Talent> GetTalents()
        {
            return _context.Talents;
        }

        // GET: api/Talent/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTalent([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var talent = await _context.Talents.SingleOrDefaultAsync(m => m.TalentID == id);

            if (talent == null)
            {
                return NotFound();
            }

            return Ok(talent);
        }

        // PUT: api/Talent/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTalent([FromRoute] int id, [FromBody] Talent talent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != talent.TalentID)
            {
                return BadRequest();
            }

            _context.Entry(talent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TalentExists(id))
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

        // POST: api/Talent
        [HttpPost]
        public async Task<IActionResult> PostTalent([FromBody] Talent talent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DateTime data = DateTime.Now;
            talent.DataCadastro = data;

            _context.Talents.Add(talent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTalent", new { id = talent.TalentID }, talent);
        }

        // DELETE: api/Talent/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTalent([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var talent = await _context.Talents.SingleOrDefaultAsync(m => m.TalentID == id);
            if (talent == null)
            {
                return NotFound();
            }

            _context.Talents.Remove(talent);
            await _context.SaveChangesAsync();

            return Ok(talent);
        }

        private bool TalentExists(int id)
        {
            return _context.Talents.Any(e => e.TalentID == id);
        }
    }
}