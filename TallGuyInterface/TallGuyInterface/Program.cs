using TallGuyInterface;

TallGuy tallGuy = new TallGuy("Jimmy", 76);
tallGuy.TalkAboutYourself();
Console.WriteLine($"The tall guy has {tallGuy.FunnyThingIHave}");
tallGuy.Honk();

IClown.CarCapacity = 18;
Console.WriteLine(IClown.ClownCarDescription());
IClown fingersTheClown = new ScaryClown("a big red nose", 14);
fingersTheClown.Honk();
if(fingersTheClown is IScaryClown iScaryClownReference)
{
    iScaryClownReference.ScareAdults();
}

class TallGuy : IClown
{
    private string? name;
    private int height;
    public string FunnyThingIHave => "big shoes";

    public TallGuy(string? name, int height)
    {
        this.name = name;
        this.height = height;
    }

    public void TalkAboutYourself()
    {
        Console.WriteLine($"My name is {name} and I'm {height} inches tall.");
    }

    public void Honk() => Console.WriteLine("Honk honk!");
}

class FunnyClown : IClown
{
    private string funnyThingIHave;
    public string FunnyThingIHave { get { return funnyThingIHave; }}
    public FunnyClown(string funnyThingIHave)
    {
        this.funnyThingIHave = funnyThingIHave;
    }
    public void Honk()
    {
        Console.WriteLine($"Hi kids! I have {FunnyThingIHave}.");
    }
}

class ScaryClown : FunnyClown, IScaryClown
{
    private readonly int scaryThingCount;
    public ScaryClown(string funnyThing, int scaryThingCount) : base(funnyThing)
    {
        this.scaryThingCount = scaryThingCount;
    }
    public string ScaryThingIHave { get { return $"{scaryThingCount} spiders."; } }
    public void ScareLittleChildren()
    {
        Console.WriteLine($"Boo! Gotcha! Look at my {ScaryThingIHave}");
    }
}