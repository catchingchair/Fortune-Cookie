using Avalonia.Controls;

namespace Fortune_Cookie;

public partial class MainWindow : Window
{

    public MainWindow()
    {
        InitializeComponent();
    }

    public void FortuneGet_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        // get a random fortune and set the text to it
        TheFortune.Text = Fortunes.getRandomFortune();
    }
    public void FortuneReset_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        // reset the fortune list
        Fortunes.ResetFortuneList();
    }

    public void FortuneStart_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        // Initialize the fortune list (GetInstance() goes here once Singleton is implemented)
        Fortunes.ResetFortuneList();
        TheFortune.Text = Fortunes.getRandomFortune();

        // Start has done its job — hide it and reveal the operational buttons
        StartFortune.IsVisible = false;
        GetFortune.IsVisible = true;
        ResetFortune.IsVisible = true;
    }
}