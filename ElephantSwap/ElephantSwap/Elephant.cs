namespace ElephantSwap;

internal class Elephant
{
    public string Name = String.Empty;
    public int EarSize;

    public void WhoAmI()
    {
        Console.WriteLine("My name is " + Name + ".");
        Console.WriteLine("My ears are " + EarSize + " inches tall.");
    }

    public void HearMessage(string message, Elephant whoSaidIt)
    {
        Console.WriteLine(Name + " heard a message");
        Console.WriteLine(whoSaidIt.Name + " said this: " + message);
    }

    public void SpeakTo(Elephant whoToTalkTo, string message)
    {
        whoToTalkTo.HearMessage(message, this);
    }
} 