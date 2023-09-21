using BookStoreApp.BlazorWebAssembly.Services.Base;

namespace BookStoreApp.BlazorWebAssembly.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync(LoginUserDto loginModel);

        public Task Logout();
    }
}
