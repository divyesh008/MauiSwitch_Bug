using CommunityToolkit.Maui;
using Switch_Bug.ViewModels;

namespace Switch_Bug;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiApp<App>().UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddScoped<MainPage>();
        builder.Services.AddTransient<MainPageViewModel>();

        builder.Services.AddScoped<HomePage>();
        builder.Services.AddTransient<HomePageViewModel>();

        builder.Services.AddScoped<BookPage>();
        builder.Services.AddTransient<BookPageViewModel>();

        return builder.Build();
	}
}

