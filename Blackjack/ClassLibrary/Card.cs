using ClassLibrary;
using Lab03Library;

namespace Blackjack.ClassLibrary;

public class Card : ICard
{
    public CardFaceValue CardFace { get; }
    public CardSuitValue CardSuit { get; }
    
    public Card(CardFaceValue face, CardSuitValue suit)
    {
        this.CardFace = face;
        this.CardSuit = suit;
    }
    
}