namespace SloppyJoe;
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        MakeTheMenu();
    }

    private void MakeTheMenu()
    {
        MenuItem[] menuItems = new MenuItem[6];
        for(int i = 0; i < 6;  i++)
        {
            menuItems[i] = new MenuItem();
            menuItems[i].Generate();
        }

        item1.Text = menuItems[0].Description;
        price1.Text = menuItems[0].Price;

        item2.Text = menuItems[1].Description;
        price2.Text = menuItems[1].Price;

        item3.Text = menuItems[2].Description;
        price3.Text = menuItems[2].Price;

        item4.Text = menuItems[3].Description;
        price4.Text = menuItems[3].Price;

        item5.Text = menuItems[4].Description;
        price5.Text = menuItems[4].Price;

        item6.Text = menuItems[5].Description;
        price6.Text = menuItems[5].Price;

        MenuItem giacamoleMenuItem = new MenuItem();
        giacamoleMenuItem.Generate();
        guacamole.Text = "Add guacamole for " + giacamoleMenuItem.Price;
    }
}
