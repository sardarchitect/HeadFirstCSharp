using LumberjackFlapjack;

Queue<Lumberjack> lumberjackQueue = new Queue<Lumberjack> ();
string? name;
Console.Write("First lumberjack's name: ");
while (!String.IsNullOrEmpty(name = Console.ReadLine()))
{
    Console.Write("Number of flapjacks: ");
    if (int.TryParse(Console.ReadLine(), out int numberOfFlapjacks))
    {
        Lumberjack lumberjack = new Lumberjack(name);
        for (int i = 0; i < numberOfFlapjacks; i++)
        {
            lumberjack.TakeFlapjack((Flapjack)Random.Shared.Next(0, 4));
        }
        lumberjackQueue.Enqueue(lumberjack);
    }
    Console.Write("\nNext lumberjack's name (blank to end): ");
}

while (lumberjackQueue.Count > 0)
{
    Lumberjack next = lumberjackQueue.Dequeue();
    next.EatFlapjack();
}