namespace PlayingCards.Models
{
    public class CardDTO
    {
        public long Id { get; set; }
        public string? CardRank { get; set; }
        public string? CardSuit { get; set; }
        public bool InDeck { get; set; }
    }
}
