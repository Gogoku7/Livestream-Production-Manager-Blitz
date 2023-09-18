using LPMBlitz.FG.Configurations;
using LPMBlitz.Services;
using Microsoft.Extensions.Logging;

namespace LPMBlitz;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<FightingGamesConfiguration>();
        builder.Services.AddSingleton<FightingGamesDataService>();
        builder.Services.AddSingleton<FightingGamesSetQueuDataService>();
        builder.Services.AddSingleton<CommentatorsDataService>();

        return builder.Build();
	}
}
