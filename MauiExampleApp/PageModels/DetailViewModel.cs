using CommunityToolkit.Mvvm.ComponentModel;
using MauiExampleApp.Models;

namespace MauiExampleApp.PageModels;


[QueryProperty(nameof(Cosa), "Cosa")] // Si se navega por datos primitivos cambiamos (nameof(Cosa), "Cosa") por (nameof(Id), "id")
public partial class DetailViewModel : ObservableObject
{
    [ObservableProperty]
    private int id;
    [ObservableProperty]
    private Cosa cosa;
}
