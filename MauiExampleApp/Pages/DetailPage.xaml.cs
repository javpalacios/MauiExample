using MauiExampleApp.PageModels;

namespace MauiExampleApp.Pages;

public partial class DeatailPage : ContentPage
{
    public DeatailPage(DetailViewModel detailViewModel)
    {
        InitializeComponent();
        BindingContext = detailViewModel; 
    }
}
