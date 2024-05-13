using System;

namespace ClassLibrary
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
            Console.SetCursorPosition(x, y);

            string faceSymbol = GetFaceSymbol();
            string suitSymbol = GetSuitSymbol();

            Console.ForegroundColor = Suit == CardSuit.Hearts || Suit == CardSuit.Diamonds
                ? ConsoleColor.Red
                : ConsoleColor.Black;

            Console.WriteLine("┌───────┐");
            Console.WriteLine($"│{faceSymbol,-2}     │");
            Console.WriteLine($"│   {suitSymbol,-2}  │");
            Console.WriteLine("│       │");
            Console.WriteLine("└───────┘");

            Console.ResetColor();
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
                _ => throw new ArgumentException("Invalid card face"),
            };
        }

        private string GetSuitSymbol()
        {
            return Suit switch
            {
                CardSuit.Spades => "♠",
                CardSuit.Hearts => "♥",
                CardSuit.Clubs => "♣",
                CardSuit.Diamonds => "♦",
                _ => throw new ArgumentException("Invalid card suit"),
            };
        }
    }
}