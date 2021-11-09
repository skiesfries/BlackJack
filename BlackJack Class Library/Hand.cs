using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Class_Library
{
    public class Hand
    {
        protected List<ICard> _cards = new();

        public void AddCard(ICard card)
        {
            _cards.Add(card);
        }

        public void Print(int x,int y) //y will be the same, x will change to display the cards horizontally
        {
            int startingX = x;
            for (int i = 0; i < _cards.Count; i++)
            {
                _cards[i].Print(x, y);
                x += 5;

                if (i % 5 ==0) //when 5 cards have been printed move down a line and continue printing
                {
                    y += 10;
                    x = startingX;
                }
            }
        }

    }

    
}
