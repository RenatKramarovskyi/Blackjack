namespace ClassLibrary;

public interface ICard
{
    CardFace Face { get; }
    CardSuit Suit { get; }

    void Print(int x, int y);
}