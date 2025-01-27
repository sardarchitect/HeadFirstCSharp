using CardDeck;

List<Card> cards = new List<Card>();
Console.Write("Enter number of cards: ");
if (int.TryParse(Console.ReadLine(), out int numberOfCards))
{
    for (int i = 0; i < numberOfCards; i++)
    {
        cards.Add(RandomCard());
    }
}
PrintCards(cards);

cards.Sort(new CardComparerByValue());
Console.WriteLine("... sorting the cards ...");
PrintCards(cards);

Card RandomCard()
{
    return new Card((Values)Random.Shared.Next(0, 13), (Suits)Random.Shared.Next(0, 4));
}

void PrintCards(List<Card> cardList)
{
    foreach (Card card in cardList)
    {
        Console.WriteLine(card);
    }
}