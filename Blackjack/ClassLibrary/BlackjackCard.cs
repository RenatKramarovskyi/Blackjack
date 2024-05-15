namespace ClassLibrary
{
    class BlackjackCard(CardFace face, CardSuit suit) : Card(face, suit)
    {
        public int Value { get; } = face switch
        {
            CardFace.A => 11,
            CardFace._2 => 2,
            CardFace._3 => 3,
            CardFace._4 => 4,
            CardFace._5 => 5,
            CardFace._6 => 6,
            CardFace._7 => 7,
            CardFace._8 => 8,
            CardFace._9 => 9,
            CardFace._10 => 10,
            CardFace.J => 10,
            CardFace.Q => 10,
            CardFace.K => 10,
            _ => throw new ArgumentException("Invalid card face")
        };
    }
}