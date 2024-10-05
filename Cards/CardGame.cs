using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg2og3
{
    internal class CardGame
    {
        private List<Card> Cards;

        public CardGame()
        {
            Cards = new List<Card>();
        }

        public void AddCard(Suit suit, Number number)
        {
            Card card = new Card(suit, number);
            Cards.Add(card);
        }

        public List<Card> FilterCardGame(Card.FilterCardDelegate filter)
        {
            return Cards.Where(card => filter(card)).ToList();
        }

        public override string ToString()
        {
            return string.Join(", ", Cards);
        }
    }
}
