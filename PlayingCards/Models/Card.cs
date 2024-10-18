namespace PlayingCards.Models
{
    public class Card
    {
        public long Id { get; set; }
        public string? CardRank { get; set; }
        public string? CardSuit { get; set; }
        public bool InDeck { get; set; }
        public string? Secret { get; set; }
    }
}
