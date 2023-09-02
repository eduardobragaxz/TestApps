using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Collections.ObjectModel;

namespace WinUI3Test;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void MainNav_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
    {
        if(Page1Button.IsSelected)
        {
            NavFrame.Navigate(typeof(BlankPage1));
        }
        else
        {
            NavFrame.Navigate(typeof(BlankPage2));
        }
    }
}