using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    internal class CardProgram
    {
        static void Main(string[] args)
        {
            CardGame game = new CardGame();

            game.AddCard(Suit.Clubs, Number.Ace);
            game.AddCard(Suit.Hearts, Number.King);
            game.AddCard(Suit.Spades, Number.Ten);

            Console.WriteLine("All cards:");
            Console.WriteLine(game);

            Card.FilterCardDelegate filter = card => card.Suit == Suit.Clubs;

            List<Card> filteredCards = game.FilterCardGame(filter);

            Console.WriteLine("Filtered cards: ");
            foreach (var item in filteredCards)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

    }
}
