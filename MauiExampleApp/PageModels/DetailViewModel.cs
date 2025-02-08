using CommunityToolkit.Mvvm.ComponentModel;
using MauiExampleApp.Models;

namespace MauiExampleApp.PageModels;


[QueryProperty(nameof(Cosa), nameof(Cosa))]
public partial class DetailViewModel : ObservableObject
{
    [ObservableProperty]
    private int id;
    [ObservableProperty]
    private Cosa cosa;
}
