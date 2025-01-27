namespace BirdClassInheritence;

internal class Egg
{
    public double Size { get; private set; }
    public string Color { get; private set; }
    public Egg(double size, string color)
    {
        Size = size;
        Color = color;
    }
    public string Description
    {
        get
        {
            return $"A {Size: 0.00}cm {Color} egg";
        }
    }
}

internal class BrokenEgg : Egg
{
    public BrokenEgg(string color) : base(0, $"broken {color}")
    {
        Console.WriteLine("A bird lay a broken egg.");
    }
}