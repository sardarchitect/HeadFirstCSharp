using System.ComponentModel;

namespace DataBinding;
internal class Moods : INotifyPropertyChanged
{
    public string CurrentMood { get; private set; } = "I'm happy";

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged(string name)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    public void UpdateMood()
    {
        switch (Random.Shared.Next(1, 5))
        {
            case 1:
                CurrentMood = "I'm happy.";
                break;
            case 2:
                CurrentMood = "Oh so sad.";
                break;
            case 3:
                CurrentMood = "YO I AM MAD!";
                break;
            default:
                CurrentMood = "I'm feeling good.";
                break;
        }
        SemanticScreenReader.Announce(CurrentMood);
        OnPropertyChanged("CurrentMood");
    }
}
