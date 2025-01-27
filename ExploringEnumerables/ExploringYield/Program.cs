﻿IEnumerable<string> SimpleEnumerable()
{
    yield return "apples";
    yield return "oranges";
    yield return "bananas";
    yield return "unicorns";
    yield return "genda";
    yield return "haathi";
}

foreach (var s in SimpleEnumerable()) Console.WriteLine(s);