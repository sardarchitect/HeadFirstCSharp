using MAUICard;

var deck = new Deck()
    .Shuffle()
    .Take(16);

var grouped =
    from card in deck
    group card by card.Suit into suitGroup
    orderby suitGroup.Key descending
    select suitGroup;

foreach (var group in grouped)
{
    Console.WriteLine(@$"Group: {group.Key}
Count: {group.Count()}
Minimum: {group.Min()}
Maximum: {group.Max()}");
}

var filename = "deckofcards.txt";
Deck newDeck = new Deck();
newDeck.Shuffle();
for (int i = newDeck.Count - 1; i > 9; i--)
    newDeck.RemoveAt(i);

newDeck.WriteCards(filename);
Deck cardsToRead = new Deck(filename);
foreach(var card in cardsToRead)
    Console.WriteLine(card.Name);