using ElephantSwap;

Elephant lloyd = new Elephant() { Name="Lloyd", EarSize=40};
Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };

Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap.");
while (true)
{
    char keyChar = Console.ReadKey(true).KeyChar;
    Console.WriteLine("You pressed " + keyChar);
    if ((keyChar == '1'))
    {
        Console.WriteLine("Calling lloyd.WhoAmI()");
        lloyd.WhoAmI();
    }
    else if (keyChar == '2')
    {
        Console.WriteLine("Calling lucinda.WhoAmI()");
        lucinda.WhoAmI();
    }
    else if (keyChar == '3')
    {
        Elephant temp = lloyd;
        lloyd = lucinda;
        lucinda = temp;

        Console.WriteLine("References have been swapped.");
    } else if(keyChar == '4') {
        lloyd = lucinda;
        lloyd.EarSize = 4321;
        lloyd.WhoAmI();
    } else if (keyChar == '5')
    {
        lucinda.SpeakTo(lloyd, "Hi, Lloyd!");
    }
    else
    {
        return;
    }
    Console.WriteLine();
}