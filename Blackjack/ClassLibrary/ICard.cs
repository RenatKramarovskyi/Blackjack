using Blackjack.ClassLibrary;
using Lab03Library;

namespace ClassLibrary;

public interface ICard 
{
    CardFaceValue CardFace { get; }
    CardSuitValue CardSuit { get; }
    
}