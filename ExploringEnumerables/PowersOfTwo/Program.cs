using System.Collections;

foreach (var result in new PowersOfTwo())
    Console.WriteLine(result);

class PowersOfTwo : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator()
    {
        var maxPower = Math.Round(Math.Log(int.MaxValue, 2));
        for (int i = 0; i < maxPower; i++)
            yield return (int)Math.Pow(2, i);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}