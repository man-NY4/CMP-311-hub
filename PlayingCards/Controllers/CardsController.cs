using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlayingCards.Models;

namespace PlayingCards.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly CardContext _context;

        public CardsController(CardContext context)
        {
            _context = context;
        }

        // GET: api/Cards
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CardDTO>>> GetCards()
        {
            return await _context.Cards.Select(x => CardToDTO(x)).ToListAsync();
        }

        // GET: api/Cards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CardDTO>> GetCard(long id)
        {
            var card = await _context.Cards.FindAsync(id);

            if (card == null)
            {
                return NotFound();
            }

            return CardToDTO(card);
        }

        // PUT: api/Cards/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCard(long id, CardDTO cardDTO)
        {
            if (id != cardDTO.Id)
            {
                return BadRequest();
            }

            var card = await _context.Cards.FindAsync(id);
            if (card == null)
            {
                return NotFound();
            }

            //_context.Entry(card).State = EntityState.Modified;
            card.CardRank = cardDTO.CardRank;
            card.CardSuit = cardDTO.CardSuit;
            card.InDeck = cardDTO.InDeck;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!CardExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        // POST: api/Cards
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CardDTO>> PostCard(CardDTO cardDTO)
        {
            var card = new Card
            {
                InDeck = cardDTO.InDeck,
                CardRank = cardDTO.CardRank,
                CardSuit = cardDTO.CardSuit
            };

            _context.Cards.Add(card);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCard), new { id = card.Id }, CardToDTO(card));
        }

        // DELETE: api/Cards/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCard(long id)
        {
            var card = await _context.Cards.FindAsync(id);
            if (card == null)
            {
                return NotFound();
            }

            _context.Cards.Remove(card);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CardExists(long id)
        {
            return _context.Cards.Any(e => e.Id == id);
        }

        private static CardDTO CardToDTO(Card card) =>
            new CardDTO
            {
                Id = card.Id,
                CardRank = card.CardRank,
                CardSuit = card.CardSuit,
                InDeck = card.InDeck
            };
    }
}
