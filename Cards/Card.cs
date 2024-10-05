using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg2og3
{
    enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    enum Number
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    internal class Card
    {
        public Suit Suit { get; }
        public Number Number { get; }

        public Card(Suit suit, Number number)
        {
            Suit = suit;
            Number = number;
        }

        public override string ToString()
        {
            return $"{Number} of {Suit}";
        }

        public delegate bool FilterCardDelegate(Card card);
    }
}
