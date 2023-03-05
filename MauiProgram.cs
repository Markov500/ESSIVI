using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.LifecycleEvents;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace ESSIVI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseSkiaSharp()
            .ConfigureLifecycleEvents(events =>
			{
#if ANDROID
				events.AddAndroid(android => android.OnCreate((activity, bundle) => MakeStatusBarTranslucent(activity)));
				static void MakeStatusBarTranslucent(Android.App.Activity activity)
				{
					activity.Window.SetStatusBarColor(Android.Graphics.Color.Rgb(34,66,124));
				}
#endif
			})
			.UseMauiMaps()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<ClientService>();

        builder.Services.AddSingleton<ClientPage>();
        builder.Services.AddSingleton<ClientVM>();

        builder.Services.AddSingleton<HomePage>();
        builder.Services.AddSingleton<HomeVM>();

        builder.Services.AddTransient<ClientDetailPage>();
		builder.Services.AddTransient<ClientDetailVM>();
		return builder.Build();
	}
}
