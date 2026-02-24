using Microsoft.Extensions.Logging;
using GestaoDeEscalas.Services;
using Microsoft.Extensions.DependencyInjection;
using Syncfusion.Maui.Core.Hosting;
using Syncfusion.Licensing;

namespace GestaoDeEscalas
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1JGaF1cXmhKYVFyWmFZfVhgfV9CaVZSTWYuP1ZhSXxVdkdhW35ecHZWRWBcUUd9XEA=");

            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("BebasNeue-Regular.ttf", "BebasNeue");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<HttpClient>();
            builder.Services.AddSingleton<AuthService>();
            //builder.Services.AddHttpClient<AuthService>();

            return builder.Build();
        }
    }
}