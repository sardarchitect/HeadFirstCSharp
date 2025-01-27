using DamageCalculator;
namespace MAUIDamageCalculator;

public partial class MainPage : ContentPage
{
    SwordDamage swordDamage = new SwordDamage(3);

    public MainPage()
    {
        InitializeComponent();
        swordDamage.Magic = Magic.IsChecked;
        swordDamage.Flaming = Flaming.IsChecked;
        DisplayDamage();
    }

    private void RollDice()
    {
        swordDamage.Roll = Random.Shared.Next(1, 7) + Random.Shared.Next(1, 7) + Random.Shared.Next(1, 7);
        DisplayDamage();
    }

    private void DisplayDamage()
    {
        Damage.Text = $"Rolled {swordDamage.Roll} for {swordDamage.Damage} HP";
    }

    private void Flaming_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        swordDamage.Flaming = e.Value;
        DisplayDamage();
    }
    private void Magic_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        swordDamage.Magic = e.Value;
        DisplayDamage();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        RollDice();
    }
}
