namespace ScrabbleScoreAPI.Models
{
    public class ScoringValueSet
    {
        public long Id { get; set; }
        public ScoringValueItem[] ScoringValuesSet { get; set; }
    }
}