using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class Hand
    {
        private const int MaxX = 108;
        private const int YIncrement = 8;
        private const int XIncrement = 12;

        protected List<ICard> Cards { get; } = new List<ICard>();

        public virtual void AddCard(ICard card)
        {
            Cards.Add(card);
        }

        public virtual void Print(int x, int y)
        {
            foreach (var card in Cards)
            {
                if (x >= MaxX)
                {
                    x = 0;
                    y += YIncrement;
                }

                card.Print(x, y);
                x += XIncrement;
            }
        }
    }
}