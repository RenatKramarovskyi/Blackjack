using ClassLibrary;
using Lab03Library;

namespace Blackjack.ClassLibrary;

public interface ICardPrinter
{
    void Print(CardFaceValue face, CardSuitValue suit, int x, int y);
}