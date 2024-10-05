using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg2og3
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
        }

    }
}
