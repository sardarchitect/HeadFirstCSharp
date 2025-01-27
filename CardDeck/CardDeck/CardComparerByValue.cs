﻿namespace CardDeck;
internal class CardComparerByValue : IComparer<Card>
{
    public int Compare(Card? x, Card? y)
    {
        if (x==null && y == null) return 0;
        if (x.Suit < y.Suit) return -1;
        else if (x.Suit > y.Suit) return 1;
        else
            if (x.Value < y.Value) return -1;
            else if (x.Value > y.Value) return 1;
            else return 0;
    }
}
