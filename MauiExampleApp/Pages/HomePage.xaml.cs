using MauiExampleApp.PageModels;

namespace MauiExampleApp.Pages;

public partial class HomePage : ContentPage
{
    public HomePage(HomeViewModel mainViewModel)
    {
        InitializeComponent();
        BindingContext = mainViewModel;
    }
}
