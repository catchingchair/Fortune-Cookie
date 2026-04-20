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
       // FortuneText.Text = Fortunes.getRandomFortune();
    }
    public void FortuneReset_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        // reset the fortune list
        Fortunes.ResetFortuneList();
    }
}