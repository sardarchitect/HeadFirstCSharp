namespace DamageCalculator;

class SwordDamage
{
    public const int BASE_DAMAGE = 3;
    public const int FLAME_DAMAGE = 2;
    private bool flaming;
    private bool magic;
    private int roll;
    /// <summary>
    /// Contains the calculated damage.
    /// </summary>
    public int Damage { get; private set; }
    /// <summary>
    /// Sets or gets 3d6 roll.
    /// </summary>
    public int Roll
    {
        get { return roll; }
        set
        {
            roll = value;
            CalculateDamage();
        }
    }
    /// <summary>
    /// True if sword is flaming, false if not.
    /// </summary>
    public bool Flaming
    {
        get { return flaming; }
        set
        {
            flaming = value;
            CalculateDamage();
        }
    }
    /// <summary>
    /// True if sword is magic, false if not.
    /// </summary>
    public bool Magic
    {
        get { return magic; }
        set
        {
            magic = value;
            CalculateDamage();
        }
    }

    private void CalculateDamage()
    {
        decimal magicMultiplier = 1M;
        if (Magic) magicMultiplier = 1.75M;
        Damage = BASE_DAMAGE;
        Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
        if (flaming) Damage += FLAME_DAMAGE;
    }
    public SwordDamage(int startingRoll)
    {
        roll = startingRoll;
        CalculateDamage();
    }
}
