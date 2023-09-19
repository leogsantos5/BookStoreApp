using BookStoreApp.BlazorMAUI;
using Microsoft.AspNetCore.Components.WebView.Maui;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Components.Authorization;
using BookStoreApp.BlazorMAUI.Providers;
using BookStoreApp.BlazorMAUI.Services;
using BookStoreApp.BlazorMAUI.Services.Authentication;
using BookStoreApp.BlazorMAUI.Services.Base;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.DependencyInjection;

namespace BookStoreApp.BlazorMAUI
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
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddBlazoredLocalStorage();

            string baseUrl = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5129" : "http://localhost:7281"; 
            builder.Services.AddHttpClient<IClient, Client>(client => client.BaseAddress = new Uri(baseUrl));
            builder.Services.AddScoped<AuthenticationStateProvider>(p => p.GetRequiredService<ApiAuthStateProvider>());
            builder.Services.AddScoped<IAuthorService, AuthorService>();

            builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();

            builder.Services.AddScoped<ApiAuthStateProvider>();

        #if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
        #endif

            //builder.Services.AddSingleton<WeatherForecastService>();

            return builder.Build();
        }
    }
}