using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using System.Diagnostics;

namespace AvaloniaApplication16.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    public void ButtonClicked(object source, RoutedEventArgs args)
    {
        string userInput = inputTextBox.Text;
        outputTextBlock.Text = userInput;
    }


    public void ButtonClicked2(object sender, RoutedEventArgs args)
    {
        Button button = (Button)sender;
        if (button.Background is SolidColorBrush brush && brush.Color == Colors.Red)
        {
            button.Background = new SolidColorBrush(Colors.Yellow);
        } else
        {
            button.Background = new SolidColorBrush(Colors.Red);
        }
    }


}
