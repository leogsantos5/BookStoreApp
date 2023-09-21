using Blazored.LocalStorage;
using BookStoreApp.BlazorWebAssembly.Providers;
using BookStoreApp.BlazorWebAssembly.Services.Base;
using Microsoft.AspNetCore.Components.Authorization;

namespace BookStoreApp.BlazorWebAssembly.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IClient httpClient;
        private readonly ILocalStorageService localStorage;
        private readonly AuthenticationStateProvider authenticationStateProvider;

        public AuthenticationService(IClient httpClient, ILocalStorageService localStorage, AuthenticationStateProvider authenticationStateProvider)
        {
            this.httpClient = httpClient;
            this.localStorage = localStorage;
            this.authenticationStateProvider = authenticationStateProvider;
        }
        public async Task<bool> AuthenticateAsync(LoginUserDto loginModel)
        {
            var response = await httpClient.LoginAsync(loginModel);

            // Store Token
            await localStorage.SetItemAsync("accessToken", response.Token);

            // Change auth state of app
            await ((ApiAuthStateProvider)authenticationStateProvider).LoggedIn();

            return true;
        }

        public async Task Logout()
        {
            // Change auth state of app
            await ((ApiAuthStateProvider)authenticationStateProvider).LoggedOut();
        }
    }
}
