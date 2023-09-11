using BookStoreApp.BlazorServer.Services.Base;

namespace BookStoreApp.BlazorServer.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync(LoginUserDto loginModel);

        public Task Logout();
    }
}
