using DamageCalculator;

SwordDamage swordDamage = new SwordDamage(RollD6Dice(3));
ArrowDamage arrowDamage = new ArrowDamage(RollD6Dice(1));

while (true)
{
    Console.Write("\n0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
    char key = Console.ReadKey().KeyChar;
    
    if (key != '0' && key != '1' && key != '2' && key != '3') return;

    Console.Write("\nS for sword, A for arrow, anything else to quit: ");
    char weaponKey = Char.ToUpper(Console.ReadKey().KeyChar);

    switch (weaponKey)
    {
        case 'S':
            swordDamage.Roll = RollD6Dice(3);
            swordDamage.Magic = (key == '1' || key == '3');
            swordDamage.Flaming = (key == '2' || key == '3');
            Console.WriteLine("\nRolled " + swordDamage.Roll + " for " + swordDamage.Damage + " HP");
            break;

        case 'A':
            arrowDamage.Roll = RollD6Dice(1);
            arrowDamage.Magic = (key == '1' || key == '3');
            arrowDamage.Flaming = (key == '2' || key == '3');
            Console.WriteLine("\nRolled " + arrowDamage.Roll + " for " + arrowDamage.Damage + " HP");
            break;

        default:
            return;
    }
}
int RollD6Dice(int numberOfDice)
{
    int sum = 0;
    for (int i = 0; i < numberOfDice; i++)
    {
        sum += Random.Shared.Next(1, 7);
    }
    return sum;
}