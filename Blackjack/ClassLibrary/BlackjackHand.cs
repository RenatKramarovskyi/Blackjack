using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary
{
    public class BlackjackHand : Hand
    {
        public int Score { get; private set; }
        public bool IsDealer { get; set; } = false;

        public BlackjackHand(bool isDealer = false)
        {
            IsDealer = isDealer;
        }

        public override void AddCard(ICard card)
        {
            base.AddCard(card);
            UpdateScore();
        }

        private void UpdateScore()
        {
            Score = 0;
            int aceCount = 0;

            foreach (var card in Cards)
            {
                if (card is BlackjackCard blackjackCard)
                {
                    if (blackjackCard.Face == CardFace.A)
                        aceCount++;
                    else
                        Score += blackjackCard.Value;
                }
            }

            for (int i = 0; i < aceCount; i++)
            {
                if (Score + 11 <= 21)
                    Score += 11;
                else
                    Score += 1;
            }
        }

        public override void Print(int x, int y)
        {
            foreach (var card in Cards)
            {
                card.Print(x, y);
                y += 5;
            }

            Console.SetCursorPosition(x, y);
            Console.WriteLine($"Score: {Score}");
        }
        public int CountCards()
        {
            return Cards.Count;
        }

        public void PrintReveal(int x, int y)
        {
            if (Cards.Count > 0)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine("┌───────┐");
                Console.WriteLine("│       │");
                Console.WriteLine("│   ?   │");
                Console.WriteLine("│       │");
                Console.WriteLine("└───────┘");

                for (int i = 1; i < Cards.Count; i++)
                {
                    Cards[i].Print(x, y + 12);
                }
            }
        }
    }
}
