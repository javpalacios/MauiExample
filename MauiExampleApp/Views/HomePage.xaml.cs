using CommunityToolkit.Mvvm.ComponentModel;
using MauiExampleApp.Models;
using System.Collections.ObjectModel;

namespace MauiExampleApp.Views;

public partial class HomePage : ContentPage
{
    public HomePage(HomeViewModel mainViewModel)
    {
        InitializeComponent();
        BindingContext = mainViewModel;
    }
}
