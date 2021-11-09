using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

 namespace BlackJack_Class_Library
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }

        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            Face = face;
            Suit = suit;
        }

        public void Print(int x, int y)
        {
            SetCursorPosition(x, y);

        }
    }
}
