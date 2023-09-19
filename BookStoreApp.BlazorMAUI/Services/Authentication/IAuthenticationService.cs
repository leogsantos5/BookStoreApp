using BookStoreApp.BlazorMAUI.Services.Base;

namespace BookStoreApp.BlazorMAUI.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync(LoginUserDto loginModel);

        public Task Logout();
    }
}
