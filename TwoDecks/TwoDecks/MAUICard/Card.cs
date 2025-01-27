namespace MAUICard;
internal enum Suits
{
    Diamonds,
    Spades,
    Hearts,
    Clubs,
}

public enum Values
{
    Ace,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King,
}

internal class Card(Suits suit, Values value)
{
    public Suits Suit { get { return suit; } }
    public Values Value { get { return value; } }
    public string Name { get { return $"{Value} of {Suit}"; } }
    public override string ToString()
    {
        return Name;
    }
}