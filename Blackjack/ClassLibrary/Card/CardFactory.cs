using ClassLibrary;

namespace ClassLibrary
{
    public static class CardFactory
    {
        public static ICard CreateCard(CardFace face, CardSuit suit)
        {
            return new Card(face, suit);
        }

        public static ICard CreateBlackjackCard(CardFace face, CardSuit suit)
        {
            return new BlackjackCard(face, suit);
        }
    }
}