using System.Collections.ObjectModel;

namespace MAUICard;
internal class Deck : ObservableCollection<Card>
{
    public Deck()
    {
        Reset();
    }
    public Deck(string fileName)
    {
        var sr = new StreamReader(fileName);
        while (!sr.EndOfStream)
        {
            var nextCard = sr.ReadLine();
            var cardParts = nextCard.Split(new char[] { ' ' });
            var value = cardParts[0] switch
            {
                "Ace" => Values.Ace,
                "Two" => Values.Two,
                "Three" => Values.Three,
                "Four" => Values.Four,
                "Five" => Values.Five,
                "Six" => Values.Six,
                "Seven" => Values.Seven,
                "Eight" => Values.Eight,
                "Nine" => Values.Nine,
                "Ten" => Values.Ten,
                "Jack" => Values.Jack,
                "Queen" => Values.Queen,
                "King" => Values.King,
                _ => throw new InvalidDataException($"Unrecognized card value: {cardParts[0]}")
            };
            var suit = cardParts[2] switch
            {
                "Diamonds" => Suits.Diamonds,
                "Spades" => Suits.Spades,
                "Hearts" => Suits.Hearts,
                "Clubs" => Suits.Clubs,
                _ => throw new InvalidDataException($"Unrecognized card suit: {cardParts[2]}")
            };
            Add(new Card(suit, value));
        }
    }
    public void Reset()
    {
        Clear();
        for (int suit = 0; suit < 4; suit++)
            for (int value = 0; value < 13; value++)
                Add(new Card((Suits)suit, (Values)value));
    }

    public Deck Shuffle()
    {
        List<Card> copy = new List<Card>(this);
        Clear();
        while (copy.Count > 0)
        {
            int index = Random.Shared.Next(0, copy.Count);
            Card card = copy[index];
            copy.RemoveAt(index);
            Add(card);
        }
        return this;
    }
    public void Sort()
    {
        List<Card> sortedCards = new List<Card>(this);
        sortedCards.Sort(new CardCompareByValue());
        Clear();
        foreach (Card card in sortedCards)
        {
            Add(card);
        }
    }
    public void WriteCards(string fileName)
    {
        var sw = new StreamWriter(fileName);
        foreach (Card card in this)
        {
            sw.WriteLine(card.ToString());
        }
        sw.Close();
    }

}
