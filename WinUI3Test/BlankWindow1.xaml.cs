using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;

namespace WinUI3Test;

public sealed partial class BlankWindow1 : Window
{
    public BlankWindow1()
    {
        InitializeComponent();
        AppWindow appWindow = GetAppWindow();
        OverlappedPresenter overlappedPresenter = appWindow.Presenter as OverlappedPresenter;
        overlappedPresenter.IsModal = true;
    }

    private AppWindow GetAppWindow()
    {
        var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);

        // Retrieve the WindowId that corresponds to hWnd.
        Microsoft.UI.WindowId windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);

        // Lastly, retrieve the AppWindow for the current (XAML) WinUI 3 window.
       return AppWindow.GetFromWindowId(windowId);
    }
}
