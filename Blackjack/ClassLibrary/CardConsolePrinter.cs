using System;
using ClassLibrary;
using Lab03Library;

namespace Blackjack.ClassLibrary
{
    public class CardConsolePrinter : ICardPrinter
    {
        public void Print(CardFaceValue face, CardSuitValue suit, int x, int y)
        {
            Console.SetCursorPosition(x, y);

            Console.ForegroundColor = suit == CardSuitValue.Hearts || suit == CardSuitValue.Diamonds
                ? ConsoleColor.Red
                : ConsoleColor.Black;

            string[] cardLines = GetCardLines(face, suit);

            foreach (string line in cardLines)
            {
                Console.WriteLine(line);
            }

            Console.ResetColor();
        }

        private string[] GetCardLines(CardFaceValue face, CardSuitValue suit)
        {
            string suitSymbol = GetSuitSymbol(suit);
            string faceSymbol = GetFaceSymbol(face);
            string[] lines = new string[7];

            lines[0] = "┌───────┐";

            lines[1] = $"│{faceSymbol,-2}     │";
            lines[2] = $"│   {suitSymbol,-2}  │";
            lines[3] = "│       │";

            lines[4] = "└───────┘";

            lines[5] = "";

            return lines;
        }

        private string GetSuitSymbol(CardSuitValue suit)
        {
            return suit switch
            {
                CardSuitValue.Spades => "♠",
                CardSuitValue.Hearts => "♥",
                CardSuitValue.Clubs => "♣",
                CardSuitValue.Diamonds => "♦",
                _ => throw new ArgumentException("Invalid card suit"),
            };
        }

        private string GetFaceSymbol(CardFaceValue face)
        {
            return face switch
            {
                CardFaceValue.A => "A",
                CardFaceValue._2 => "2",
                CardFaceValue._3 => "3",
                CardFaceValue._4 => "4",
                CardFaceValue._5 => "5",
                CardFaceValue._6 => "6",
                CardFaceValue._7 => "7",
                CardFaceValue._8 => "8",
                CardFaceValue._9 => "9",
                CardFaceValue._10 => "10",
                CardFaceValue.J => "J",
                CardFaceValue.Q => "Q",
                CardFaceValue.K => "K",
                _ => throw new ArgumentException("Invalid card face"),
            };
        }
    }
}
