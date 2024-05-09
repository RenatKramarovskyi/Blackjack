/*using Blackjack.ClassLibrary;
using ClassLibrary;
using Lab03Library;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("┌─────┐");
        ICardPrinter cardPrinter = new CardConsolePrinter();
        ConcreteGameCard cardGame = new ConcreteGameCard(cardPrinter);

        ICard card = new Card(CardFaceValue.A, CardSuitValue.Diamonds);
        ICard card2 = new Card(CardFaceValue._7, CardSuitValue.Hearts);
        cardGame.PrintCard(card, 0, 0);
        cardGame.PrintCard(card2, 0, 5);
        
    }
}*/

using System;
using Blackjack.ClassLibrary;
using ClassLibrary;
using Lab03Library;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("┌──────────┐┌──────────┐┌──────────┐");

        ICardPrinter cardPrinter = new CardConsolePrinter();
        ConcreteGameCard cardGame = new ConcreteGameCard(cardPrinter);

        ICard card1 = new Card(CardFaceValue.A, CardSuitValue.Diamonds);
        ICard card2 = new Card(CardFaceValue._7, CardSuitValue.Hearts);
        ICard card3 = new Card(CardFaceValue._10, CardSuitValue.Clubs);

        // Print cards horizontally
        cardGame.PrintCard(card1, 0, 0);
        cardGame.PrintCard(card2, 0, 5);
        cardGame.PrintCard(card3, 0, 10);
    }
}
