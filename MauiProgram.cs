﻿using CommunityToolkit.Maui;

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

		return builder.Build();
	}
}
