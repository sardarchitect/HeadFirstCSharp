namespace TallGuyInterface;
internal interface IClown
{
    public abstract string FunnyThingIHave { get; }
    public abstract void Honk();
    private static int carCapacity = 12;
    public static int CarCapacity
    {
        get { return carCapacity; }
        set
        {
            if (value > 10) carCapacity = value;
            else Console.Error.WriteLine($"Warning: Car capacity {value} is too small.");
        }
    }
    public static string ClownCarDescription()
    {
        return $"A clown car with {Random.Shared.Next(CarCapacity / 2, CarCapacity)} clowns";
    }
}

internal interface IScaryClown : IClown
{
    string ScaryThingIHave { get; }
    void ScareLittleChildren();
    void ScareAdults()
    {
        Console.WriteLine($@"I am an ancient evil that will haunt your nightmares.
Behold my necklace with {Random.Shared.Next(4, 10)} of my last victim's fingers.
Oh, also, before I forget...");
        ScareLittleChildren();
    }
}
