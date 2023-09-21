using FinalProject_190209998.DataTrans;
using Microsoft.Extensions.Logging;

namespace FinalProject_190209998;

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

		string _Path = Path.Combine(FileSystem.AppDataDirectory, "MiniMarket6.db");
		builder.Services.AddSingleton(s =>
		ActivatorUtilities.CreateInstance<MarketDB>(s, _Path));

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
