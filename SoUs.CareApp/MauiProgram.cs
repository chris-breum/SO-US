using Microsoft.Extensions.Logging;
using SoUs.CareApp.viewModels;
using SoUs.CareApp.Views;
using SoUs.services;

namespace SoUs.CareApp
{
    public static class MauiProgram
    {
        private const string url = "https://localhost:7233/";
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
            Uri baseUri = new Uri(url);
            builder.Services.AddScoped<ISoUsService>(x => new SoUsService(baseUri));
            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<MainPage>();
          

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
