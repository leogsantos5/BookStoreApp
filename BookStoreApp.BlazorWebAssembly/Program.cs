using Blazored.LocalStorage;
using BookStoreApp.BlazorWebAssembly;
using BookStoreApp.BlazorWebAssembly.Providers;
using BookStoreApp.BlazorWebAssembly.Services;
using BookStoreApp.BlazorWebAssembly.Services.Authentication;
using BookStoreApp.BlazorWebAssembly.Services.Base;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7281") });

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped<ApiAuthStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>(p => p.GetRequiredService<ApiAuthStateProvider>());
builder.Services.AddAuthorizationCore();

builder.Services.AddScoped<IClient, Client>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<IAuthorService, AuthorService>();
builder.Services.AddScoped<IBookService, BookService>();

await builder.Build().RunAsync();
