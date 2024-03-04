using Microsoft.Extensions.Logging;
using TriviaApp.Services;
using TriviaApp.ViewModel;

namespace TriviaApp
{
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
                    fonts.AddFont("WinterDrink.ttf", "WinterDrink");
                });
            //builder
           

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}