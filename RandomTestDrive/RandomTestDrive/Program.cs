int randomInt = Random.Shared.Next(1, 7);
Console.WriteLine(randomInt);

double randomDouble = Random.Shared.NextDouble();
Console.WriteLine(randomDouble * 100);
Console.WriteLine((float)randomDouble * 100F);
Console.WriteLine((decimal)randomDouble * 100M);

int zeroOrOne = Random.Shared.Next(2);
bool coinFlip = Convert.ToBoolean(zeroOrOne);
Console.WriteLine(coinFlip);