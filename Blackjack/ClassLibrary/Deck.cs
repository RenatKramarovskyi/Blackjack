using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class Deck
    {
        private const int CardsInSuit = 13;
        private const int SuitsInDeck = 4;
        private const int TotalCards = 52;
        private const int MaxX = 108;
        private const int YIncrement = 8;
        private const int XIncrement = 12;

        private List<ICard> _cards = new List<ICard>();
        private Random _rng = new Random();

        public Deck()
        {
            InitializeDeck();
        }

        public void InitializeDeck()
        {
            _cards.Clear();
            for (int suit = 0; suit < SuitsInDeck; suit++)
            {
                for (int face = 0; face < CardsInSuit; face++)
                {
                    _cards.Add(CardFactory.CreateBlackjackCard((CardFace)face, (CardSuit)suit));
                }
            }
        }

        public void Shuffle()
        {
            for (int i = _cards.Count - 1; i > 0; i--)
            {
                int j = _rng.Next(i + 1);
                (_cards[j], _cards[i]) = (_cards[i], _cards[j]);
            }
        }

        public ICard Deal()
        {
            if (_cards.Count == 0)
            {
                InitializeDeck();
                Shuffle();
            }
            ICard cardToDeal = _cards[0];
            _cards.RemoveAt(0);
            return cardToDeal;
        }

        public void Print(int x, int y)
        {
            foreach (var card in _cards)
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