static class HiLoGame
{
    public const int MAXIMUM = 10;
    static private int currentNumber = Random.Shared.Next(1, MAXIMUM + 1);
    static private int nextNumber = Random.Shared.Next(1, MAXIMUM + 1);
    static private int pot = 10;

    static public void Guess(bool higher)
    {
        if ((higher && nextNumber >= currentNumber) || (!higher && nextNumber <= currentNumber))
        {
            pot += 1;
            Console.WriteLine("You guessed right!");
        } else
        {
            pot -= 1;
            Console.WriteLine("Bad luck, you guessed wrong.");
        }
        currentNumber = nextNumber;
        nextNumber = Random.Shared.Next(1, MAXIMUM + 1);
        Console.WriteLine($"The current number is {currentNumber}");
    }
    static public void Hint()
    {
        int half = MAXIMUM / 2;
        if (currentNumber >= half)
            Console.WriteLine($"The current number is {currentNumber}, the next is at least {half}");
        else
            Console.WriteLine($"The current number is {currentNumber}, the next is at most {half}");

        pot -= 1;
    }
    static public int GetPot() { return pot; }

}
