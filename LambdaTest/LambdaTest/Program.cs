new Nest(8).WriteLines();

public class Nest()
{
    public int Count { get; private set; }
    public string Chicks = GetChicks();
    public Nest(int count)
    {
        Count = count;
    }
    public static string GetChicks() => $"The nest has {Random.Shared.Next(1, 12)} chicks";
    public void WriteLines()
    {
        for (int i = 0; i < Count; i++)
            Console.WriteLine(Chicks);
    }
}