namespace ClassLibrary;

public class Hand
{
    protected List<ConcreteGameCard> _cards = new List<ConcreteGameCard>();

    public virtual void AddCard(ConcreteGameCard card)
    {
        _cards.Add(card);
    }

    public virtual void Print(int x, int y)
    {
        foreach (var item in _cards)
        {
            if (x >= 108)
            {
                x = 0;
                y += 8;
            }


            item.PrintCard(x, y);
            x += 12;
        }
    }
}