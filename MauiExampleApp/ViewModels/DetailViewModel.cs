using CommunityToolkit.Mvvm.ComponentModel;
using MauiExampleApp.Models;

namespace MauiExampleApp;
// Navegación por parámetro Query Id, Navegación por objeto Query Cosa
//[QueryProperty(nameof(Id), "id")]
[QueryProperty(nameof(Cosa), nameof(Cosa))]
public partial class DetailViewModel : ObservableObject
{
    [ObservableProperty]
    private int id;
    [ObservableProperty]
    private Cosa cosa;
}
