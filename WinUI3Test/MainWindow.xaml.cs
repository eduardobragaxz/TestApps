using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Input;
using System.Collections.ObjectModel;

namespace WinUI3Test;

public sealed partial class MainWindow : Window
{
    public ObservableCollection<string> oi = new();
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        oi.Add("whatever");
    }

    private void showbutton_Click(object sender, RoutedEventArgs e)
    {
        if(addtolist is null)
        {
            navi.FindName("addtolist");
        }
        else
        {
            UnloadObject(addtolist);
        }
    }
}