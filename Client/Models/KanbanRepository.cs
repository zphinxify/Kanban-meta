using System;
using System.Collections.Generic;
using System.Linq;
using Client.Data;

namespace Client.Models {
    public class KanbanRepository {
        private readonly KanbanContext _context;
        public KanbanRepository(KanbanContext context) {
            _context = context;
        }

        // public IEnumerable<Column> GetColumns() {
        //     return _context.Columns;
        // }

        public IEnumerable<Card> GetCards() {
            return _context.Cards;
        }

        public Card AddCard(Card cardToAdd) {
            _context.Add(cardToAdd);
            _context.SaveChanges();

            return _context.Cards.FirstOrDefault(x => x.ID == cardToAdd.ID);
        }

        public Card UpdateCard(Card updatedCard) {
            Card cardToUpdate = _context.Cards.FirstOrDefault(x => x.ID == updatedCard.ID);

            cardToUpdate = updatedCard;

            _context.SaveChanges();

            return cardToUpdate;
        }

        public Card RemoveCard(int cardID) {
            Card cardToRemove = _context.Cards.FirstOrDefault(x => x.ID == cardID);

            _context.Cards.Remove(cardToRemove);
            _context.SaveChanges();

            return cardToRemove;
        }
    }
}