using Microsoft.AspNetCore.Components.WebView.Maui;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Mafia
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .RegisterBlazorMauiWebView()
                .UseMauiApp<App>();

//            builder.Services.ConfigureServices();

            builder.Services.AddBlazorWebView();

            return builder.Build();
        }
    }
}
