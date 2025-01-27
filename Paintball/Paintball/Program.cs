static int readInt(int defaultValue, string message)
{
    Console.Write($"Please provide {message} [{defaultValue}]: ");
    string? line = Console.ReadLine();
    if (int.TryParse(line, out int value))
    {
        Console.WriteLine($" using value {value}");
        return value;
    }
    else
    {
        Console.WriteLine($" using default value {defaultValue}");
        return defaultValue;
    }
}

int numberOfBalls = readInt(20, "Number of balls");
int magazineSize = readInt(16, "Magazine size");
Console.Write($"Loaded [false]: ");
bool.TryParse(Console.ReadLine(), out bool isLoaded);

PaintballGun gun = new PaintballGun(numberOfBalls, magazineSize, isLoaded);
while (true)
{
    Console.WriteLine($"{gun.BallsLoaded}/{gun.Balls}");
    if (gun.Balls == 0) Console.WriteLine("WARNING: You are out of ammo");
    Console.WriteLine("Space to shoot, r to reload, + to add ammo, q to quit");
    char key = Console.ReadKey(true).KeyChar;
    if (key == ' ') Console.WriteLine($"Shooting returned {gun.Shoot()}");
    else if (key == 'r') gun.Reload();
    else if (key == '+') gun.Balls += gun.MagazineSize;
    else if (key == 'q') return;
}