using System.Text.Json;

List<Guy> guys = [
    new Guy("Bob", new Outfit("t-shirt", "jeans"), new HairStyle(HairColor.Red, 3.5f)),
    new Guy("Joe", new Outfit("polo", "slacks"), new HairStyle(HairColor.Gray, 2.7f))
    ];

var options = new JsonSerializerOptions() { WriteIndented = true };
var jsonString = JsonSerializer.Serialize(guys, options);
Console.WriteLine(jsonString);

var copyOfGuys = JsonSerializer.Deserialize<List<Guy>>(jsonString);
if(copyOfGuys != null )
    foreach (var guy in copyOfGuys)
        Console.WriteLine(guy);

Console.WriteLine(JsonSerializer.Serialize(3));
Console.WriteLine(JsonSerializer.Serialize((long)-3));
Console.WriteLine(JsonSerializer.Serialize((byte)0));
Console.WriteLine(JsonSerializer.Serialize(float.MaxValue));
Console.WriteLine(JsonSerializer.Serialize(float.MinValue));
Console.WriteLine(JsonSerializer.Serialize(true));
Console.WriteLine(JsonSerializer.Serialize("Elephant"));
Console.WriteLine(JsonSerializer.Serialize("Elephant".ToCharArray()));
Console.WriteLine(JsonSerializer.Serialize("🐘"));

class Guy(string? name, Outfit? clothes, HairStyle? hair)
{
    public string? Name => name;
    public HairStyle? Hair => hair;
    public Outfit? Clothes => clothes;
    public override string ToString() => $"{Name} with {Hair} wearing {Clothes}";
}

class Outfit(string? top, string? bottom)
{
    public string? Top => top;
    public string? Bottom => bottom;
    public override string ToString() => $"{Top} and {Bottom}";
}

enum HairColor
{
    Auburn, Black, Blonde, Blue, Brown, Gray, Platinum, Purple, Red, White
}
class HairStyle(HairColor? color, float length)
{
    public HairColor? Color => color;
    public float Length => length;
    public override string ToString() => $"{Length:0.0} inch {Color} hair";
}