using MauiExampleApp.Models;

namespace MauiExampleApp.Services;

public class DummyService
{
    public List<Cosa> GetAllCosas() => [
        new Cosa { Id = 0, Name = "Una cosa" },
        new Cosa { Id = 1, Name = "Otra cosa" },
        new Cosa { Id = 2, Name = "Otra cosa más" },
    ];
}
