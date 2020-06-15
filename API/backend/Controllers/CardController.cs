using System.Collections.Generic;
using System.Threading.Tasks;
using Meta.Api.Data;
using Meta.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Meta.Api.Controllers {
    [Route("api/[Controller]")]
    [ApiController]
    public class CardController : ControllerBase {
        private readonly CardContext _context;

        public CardController(CardContext context) {
            _context = context;
        }

        [HttpGet] 
        public async Task<ActionResult<IEnumerable<Card>>> GetAllCards() {
            return await _context.Cards.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Card>> GetCard(int id) {
            Card card = await _context.Cards.FindAsync(id);

            return card;
        }

        [HttpPost("addCard")]
        public async Task<ActionResult<Card>> AddCard(Card card) {
            _context.Add(card);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCard), new { id = card.Id}, card);
        }
    }
}