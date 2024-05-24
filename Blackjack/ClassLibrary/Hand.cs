using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Hand
    {
        protected List<ICard> _cards = new List<ICard>();

        public virtual void AddCard(ICard card)
        {
            _cards.Add(card);
        }

        public virtual void Print(int x, int y)
        {
            foreach (var card in _cards)
            {
                card.Print(x, y);
                x += 12;
                if (x >= 108)
                {
                    x = 0;
                    y += 8;
                }
            }
        }
    }
}