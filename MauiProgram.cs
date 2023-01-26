using CommunityToolkit.Maui;
using Microsoft.Extensions.DependencyInjection;
using OutlookMobileClone.Services;
using OutlookMobileClone.ViewModel;
using OutlookMobileClone.Views;

namespace OutlookMobileClone;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().UseMauiCommunityToolkit();
        builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("FluentSystemIcons-Filled.ttf", "FluentFilled");
                fonts.AddFont("FluentSystemIcons-Regular.ttf", "FluentRegular");
            });
#if DEBUG
        //builder.Logging.AddDebug();
#endif
        builder.Services.AddSingleton<MonkeyService>();
        builder.Services.AddTransient<MonkeysViewModel>();
        builder.Services.AddTransient<MonkeyMainPage>();
        Routing.RegisterRoute(nameof(MonkeyMainPage), typeof(MonkeyMainPage));

        return builder.Build();
	}
}
