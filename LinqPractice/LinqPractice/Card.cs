using MAUICard;
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

internal class Card(Suits suit, Values value) : IComparable<Card>
{
    public Suits Suit { get { return suit; } }
    public Values Value { get { return value; } }
    public string Name { get { return $"{Value} of {Suit}"; } }

    public int CompareTo(Card? other)
    {
        return new CardCompareByValue().Compare(this, other);
    }

    public override string ToString()
    {
        return Name;
    }
}