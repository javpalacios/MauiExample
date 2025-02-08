using MauiExampleApp.Services;
using MauiExampleApp.Pages;
using Microsoft.Extensions.Logging;
using MauiExampleApp.PageModels;

namespace MauiExampleApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
		builder.Logging.AddDebug();
        builder.Services.AddSingleton<DummyService>();
        builder.Services.AddSingleton<DetailViewModel>();
        builder.Services.AddSingleton<HomeViewModel>();
        builder.Services.AddSingleton<DeatailPage>();
        builder.Services.AddSingleton<HomePage>();
#endif

        return builder.Build();
    }
}
