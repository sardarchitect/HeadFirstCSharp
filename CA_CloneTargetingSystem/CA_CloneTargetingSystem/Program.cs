using Serilog;
using CA_CloneTargetingSystem;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File($"log-{DateTime.Now:yyyyMMdd-HHmmss}.log")
    .CreateLogger();

Log.Information($"App started with {0} argument(s): {1}", args.Length, args);
if (args.Length < 1)
    Log.Warning("No arguments found");

Console.Clear();
//Seed Clones
List<Clone> cloneList = Clone.CloneNames
    .Select(name => new Clone(name, Random.Shared.Next(1, Clone.MAX_ID))).ToList();

//Controls - Initial Values
int selectedName = 0;
int selectedId = 1;
DateTime startTime = DateTime.Now;
DateTime lastAddTime = DateTime.Now;

//Engine
while (cloneList.Count > 0)
{
    Console.SetCursorPosition(0, 0);

    //Controls - Clone Name Selection
    Console.Write("Name:\t");
    for (int i = 0; i < Clone.CloneNames.Count; i++)
    {
        string name = Clone.CloneNames[i];
        Console.Write($"{(i == selectedName ? name.ToUpper() : name)}\t");
    }

    //Controls - Clone ID Selection
    Console.Write("\nID:\t");
    for (int i = 1; i < Clone.MAX_ID; i++)
    {
        Console.Write($"{(i == selectedId ? $">{i}<" : i)}\t");
    }

    //Controls - Instructions and Dashboard
    Console.WriteLine("\n\nTarget clones: Name = up/down arrows, ID = left/right arrows, enter = fire");
    Console.Write($"Clones: {cloneList.Count}\t\tTime: {(DateTime.Now - startTime).TotalSeconds:0.0s}\n\n");

    int count = 0;
    string LineBreakOrTab() => ++count % 5 == 0 ? Environment.NewLine : "\t";
    cloneList.ForEach(clone => Console.Write($"{clone}{LineBreakOrTab()}"));

    if (Console.KeyAvailable)
    {
        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.UpArrow:
                if (selectedName > 0) selectedName--;
                break;
            case ConsoleKey.DownArrow:
                if (selectedName < Clone.CloneNames.Count - 1) selectedName++;
                break;
            case ConsoleKey.LeftArrow:
                if (selectedId > 1) selectedId--;
                break;
            case ConsoleKey.RightArrow:
                if (selectedId < Clone.MAX_ID) selectedId++;
                break;
            case ConsoleKey.Enter:
                var target = new Clone(Clone.CloneNames[selectedName], selectedId);
                cloneList.Remove(target);
                break;
        }
    }

    //GenerateClone() runs every 1.5 seconds iff cloneCount < 31
    if (cloneList.Count < 31 && (DateTime.Now - lastAddTime).TotalSeconds > Clone.ADD_SECONDS)
    {
        var clone = cloneList[Random.Shared.Next(cloneList.Count)];
        cloneList.Add(clone with { Id = Random.Shared.Next(1, Clone.MAX_ID + 1) });
        lastAddTime = DateTime.Now;
    }
    Thread.Sleep(Clone.FRAME_DELAY_MILLISECONDS);
}

Console.WriteLine($"You won in {(DateTime.Now - startTime).TotalSeconds:0.0} seconds");

Log.CloseAndFlush();