using DamageCalculator;

SwordDamage swordDamage = new SwordDamage(RollDice());

while (true)
{
    Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
    char keyChar = Console.ReadKey().KeyChar;
    if (keyChar != '0' && keyChar != '1' && keyChar != '2' && keyChar != '3') return;
    int roll = RollDice();
    swordDamage.Magic = (keyChar == '1' || keyChar == '3');
    swordDamage.Flaming = (keyChar == '2' || keyChar == '3');
    Console.WriteLine("\nRolled " + roll + " for " + swordDamage.Damage + " HP");
}

int RollDice()
{
    return Random.Shared.Next(1, 7) + Random.Shared.Next(1, 7) + Random.Shared.Next(1, 7);
}