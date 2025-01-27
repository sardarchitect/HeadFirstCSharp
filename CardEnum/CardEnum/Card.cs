namespace CardEnum;
internal class Card (Values value, Suits suit)
{
    public Suits Suit { get { return suit; } }
    public Values Value { get { return value; } }
    public string Name {
        get { return Value + " of " + Suit; }
    }
}
