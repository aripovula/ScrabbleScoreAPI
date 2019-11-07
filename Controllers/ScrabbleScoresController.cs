using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScrabbleScoreAPI.Models;

namespace ScrabbleScoreAPI.Controllers
{
    [Route("api/ScrabbleScores")]
    [ApiController]
    public class ScrabbleScoresController : ControllerBase
    {
        private readonly ScrabbleScoreContext _context;

        public ScrabbleScoresController(ScrabbleScoreContext context)
        {
            _context = context;
        }

        // GET: api/ScrabbleScores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Score>>> GetScrabbleScores()
        {
            return await _context.ScrabbleScores.ToListAsync();
        }

        // GET: api/ScrabbleScores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Score>> GetScore(long id)
        {
            var score = await _context.ScrabbleScores.FindAsync(id);

            if (score == null)
            {
                return NotFound();
            }

            return score;
        }

        // GET: api/ScrabbleScores/word
        [HttpGet("word/{word}")]
        public ActionResult<Score> GetScoreForWord(string word)
        {
            int theScore = ScrabbleScore.Score(word);
            var score = new Score{ ScrabbleScore = theScore, Word = word };

            if (score == null)
            {
                return NotFound();
            }

            return score;
        }


        // PUT: api/ScrabbleScores/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutScore(long id, Score score)
        {
            if (id != score.Id)
            {
                return BadRequest();
            }

            _context.Entry(score).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScoreExists(id))
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

        // POST: api/ScrabbleScores
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Score>> PostScore(Score score)
        {
            _context.ScrabbleScores.Add(score);
            await _context.SaveChangesAsync();

            // return CreatedAtAction("GetScore", new { id = score.Id }, score);
            return CreatedAtAction(nameof(GetScore), new { id = score.Id }, score);
        }

        // DELETE: api/ScrabbleScores/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Score>> DeleteScore(long id)
        {
            var score = await _context.ScrabbleScores.FindAsync(id);
            if (score == null)
            {
                return NotFound();
            }

            _context.ScrabbleScores.Remove(score);
            await _context.SaveChangesAsync();

            return score;
        }

        private bool ScoreExists(long id)
        {
            return _context.ScrabbleScores.Any(e => e.Id == id);
        }
    }
}
