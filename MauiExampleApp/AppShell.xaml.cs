using MauiExampleApp.Views;

namespace MauiExampleApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        InitializeRouting();
    }

    private static void InitializeRouting()
    {
        Routing.RegisterRoute("home/details", typeof(DeatailPage));
    }
}
