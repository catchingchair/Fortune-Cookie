using Avalonia.Controls;

namespace Fortune_Cookie;

public partial class MainWindow : Window
{
    // The UI needs to hold a reference to the Fortune object
    private Fortune _fortune = Fortune.GetInstance();

    public MainWindow()
    {
        InitializeComponent();
    }

    public void FortuneStart_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        TheFortune.Text = _fortune.GetNextFortune();

        StartFortune.IsVisible = false;
        GetFortune.IsVisible = true;
        ResetFortune.IsVisible = true;
    }

    public void FortuneGet_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        TheFortune.Text = _fortune.GetNextFortune();
    }

    public void FortuneReset_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        _fortune.Reshuffle();
    }
}