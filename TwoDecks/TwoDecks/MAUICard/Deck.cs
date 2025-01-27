using System.Collections.ObjectModel;

namespace MAUICard;
internal class Deck : ObservableCollection<Card>
{
    public Deck()
    {
        Reset();
    }
    public void Reset()
    {
        Clear();
        for (int suit = 0; suit < 4; suit++)
            for (int value = 0; value < 13; value++)
                Add(new Card((Suits)suit, (Values)value));
    }
    public void Shuffle()
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
}
