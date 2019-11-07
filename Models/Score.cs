namespace ScrabbleScoreAPI.Models
{
    public class Score
    {
        public long Id { get; set; }
        public int ScrabbleScore { get; set; }
        public string Word { get; set; }
        public long ScoringValueSetId { get; set; }

    }
}