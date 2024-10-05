using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
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
            List<Card> filteredCards = new List<Card>();
            foreach (var card in Cards)
            {
                if (filter(card))
                {
                    filteredCards.Add(card);
                }
            }
            return filteredCards;
        }

        public override string ToString()
        {
            return string.Join(", ", Cards);
        }
    }
}
