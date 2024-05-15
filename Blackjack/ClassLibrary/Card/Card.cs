using System;

namespace ClassLibrary
{
    public class Card(CardFace face, CardSuit suit) : ICard
    {
        private const string SpadeSymbol = "♠";
        private const string HeartSymbol = "♥";
        private const string ClubSymbol = "♣";
        private const string DiamondSymbol = "♦";

        public CardFace Face { get; private set; } = face;
        public CardSuit Suit { get; private set; } = suit;

        public void Print(int x, int y)
        {
            // Перевірка, чи координати не виходять за межі буфера консолі
            if (y >= 0 && y < Console.BufferHeight)
            {
                Console.SetCursorPosition(x, y);

                string faceSymbol = GetFaceSymbol();
                string suitSymbol = GetSuitSymbol();

                Console.ForegroundColor = Suit == CardSuit.Hearts || Suit == CardSuit.Diamonds
                    ? ConsoleColor.Red
                    : ConsoleColor.Black;

                PrintCardLine("┌───────┐", x, y++);
                PrintCardLine($"│{faceSymbol,-2}     │", x, y++);
                PrintCardLine($"│   {suitSymbol,-2}  │", x, y++);
                PrintCardLine("│       │", x, y++);
                PrintCardLine("└───────┘", x, y);

                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Помилка: Значення 'y' виходить за межі буфера консолі.");
            }
        }


        private void PrintCardLine(string line, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(line);
        }

        private string GetFaceSymbol()
        {
            return Face switch
            {
                CardFace.A => "A",
                CardFace._2 => "2",
                CardFace._3 => "3",
                CardFace._4 => "4",
                CardFace._5 => "5",
                CardFace._6 => "6",
                CardFace._7 => "7",
                CardFace._8 => "8",
                CardFace._9 => "9",
                CardFace._10 => "10",
                CardFace.J => "J",
                CardFace.Q => "Q",
                CardFace.K => "K",
                _ => "?"
            };
        }

        private string GetSuitSymbol()
        {
            return Suit switch
            {
                CardSuit.Spades => SpadeSymbol,
                CardSuit.Hearts => HeartSymbol,
                CardSuit.Clubs => ClubSymbol,
                CardSuit.Diamonds => DiamondSymbol,
                _ => "?"
            };
        }
    }
}