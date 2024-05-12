using Blackjack.ClassLibrary;
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
        ICard card2 = new Card(CardFaceValue.J, CardSuitValue.Hearts);
        cardGame.PrintCard(card, 0, 0);
        cardGame.PrintCard(card2, 0, 5);
        
    }
}

