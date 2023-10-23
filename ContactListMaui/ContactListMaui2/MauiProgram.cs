using ContactListMaui2.MVVM.ViewModels;
using ContactListMaui2.MVVM.Views;
using ContactListMaui2.Services;


namespace ContactListMaui2
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
            
            builder.Services.AddSingleton<ContactService>();

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();

            builder.Services.AddTransient<DetailPage>();
            builder.Services.AddTransient<DetailViewModel>();

            builder.Services.AddTransient<AddPage>();
            builder.Services.AddTransient<AddViewModel>();

            builder.Services.AddTransient<EditPage>();
            builder.Services.AddTransient<EditViewModel>();







            return builder.Build();
        }
    }
}