using Microsoft.UI.Xaml;

namespace WinUI3Test;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnOpenWindow_Click(object sender, RoutedEventArgs e)
    {
        BlankWindow1 blankWindow1 = new();
        blankWindow1.Activate();
    }
}