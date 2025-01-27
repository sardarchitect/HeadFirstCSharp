namespace PickRandomCards;

internal class CardPicker
{
    public static string[] PickSomeCards(int numberOfCards)
    {
        string[] pickedCards = new string[numberOfCards];
        for (int i = 0; i < numberOfCards; i++)
        {
            pickedCards[i] = RandomValue() + " of " + RandomSuit();
        }
        return pickedCards;
    }
    public static string RandomValue()
    {
        string[] values =
        {
            "Ace","Two","Three","Four",
            "Five","Six","Seven","Eight",
            "Nine", "Ten", "Jack", "Queen",
            "King"
        };
        int randomIndex = Random.Shared.Next(0,13);
        return values[randomIndex];

    }
    public static string RandomSuit()
    {
        string[] suits = 
        {
            "Hearts", "Spades", "Clubs","Diamonds"
        };
        int randomIndex = Random.Shared.Next(0,4);
        return suits[randomIndex];
    }
}