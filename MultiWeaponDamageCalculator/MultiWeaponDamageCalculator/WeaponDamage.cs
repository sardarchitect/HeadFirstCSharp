namespace MultiWeaponDamageCalculator;
internal abstract class WeaponDamage
{
    private bool flaming;
    private bool magic;
    private int roll;
    /// <summary>
    /// Contains the calculated damage.
    /// </summary>
    public int Damage { get; protected set; }
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

    protected abstract void CalculateDamage();
    public WeaponDamage(int startingRoll)
    {
        roll = startingRoll;
        CalculateDamage();
    }
}
