using Blackjack.ClassLibrary;
using ClassLibrary;

public class ConcreteGameCard
{
    private readonly ICardPrinter _cardPrinter;

    public ConcreteGameCard(ICardPrinter cardPrinter)
    {
        _cardPrinter = cardPrinter;
    }

    public void PrintCard(ICard card, int xCursorPos, int yCursorPos)
    {
        _cardPrinter.Print(card.CardFace, card.CardSuit, xCursorPos, yCursorPos);
    }
}