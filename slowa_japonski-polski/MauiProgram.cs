using Microsoft.Extensions.Logging;
using Plugin.Maui.Audio;

namespace slowa_japonski_polski {
    public static class MauiProgram {
        public static MauiApp CreateMauiApp() {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts => {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            //to play audio
            builder.Services.AddSingleton(AudioManager.Current);
            builder.Services.AddTransient<PageStartedSession>();
            builder.Services.AddTransient<PageWordCategoryList>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
