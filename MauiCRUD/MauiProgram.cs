using MauiCRUD.Services;
using MauiCRUD.ViewModels;
using MauiCRUD.Views;
using Microsoft.Extensions.Logging;

namespace MauiCRUD
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
                });

            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "cars.db3");

            builder.Services.AddSingleton<CarService>(s => ActivatorUtilities.CreateInstance<CarService>(s, dbPath));

            builder.Services.AddSingleton<CarListViewModel>();
            builder.Services.AddTransient<CarDetailsViewModel>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddTransient<CarDetailsPage>();

            return builder.Build();
        }
    }
}
