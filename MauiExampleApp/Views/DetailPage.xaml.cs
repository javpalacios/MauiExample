namespace MauiExampleApp.Views;

public partial class DeatailPage : ContentPage
{
    public DeatailPage(DetailViewModel detailViewModel)
    {
        InitializeComponent();
        BindingContext = detailViewModel; 
    }
}
