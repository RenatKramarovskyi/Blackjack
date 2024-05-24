using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Deck
    {
        private List<ICard> _cards = new List<ICard>();

        public Deck()
        {
            CreateDeck();
        }

        private void CreateDeck()
        {
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardFace face in Enum.GetValues(typeof(CardFace)))
                {
                    _cards.Add(new BlackjackCard(face, suit));
                }
            }
        }

        public void Shuffle()
        {
            Random rng = new Random();
            int n = _cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                ICard value = _cards[k];
                _cards[k] = _cards[n];
                _cards[n] = value;
            }
        }

        public ICard Deal()
        {
            if (_cards.Count == 0)
            {
                throw new InvalidOperationException("Deck is empty");
            }
            ICard card = _cards[0];
            _cards.RemoveAt(0);
            return card;
        }

        public void Print(int x, int y)
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