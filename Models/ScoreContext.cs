using Microsoft.EntityFrameworkCore;

namespace ScrabbleScoreAPI.Models
{
    public class ScrabbleScoreContext : DbContext
    {
        public ScrabbleScoreContext(DbContextOptions<ScrabbleScoreContext> options)
            : base(options)
        {
        }

        public DbSet<Score> ScrabbleScores { get; set; }
    }
}