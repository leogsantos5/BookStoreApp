using BookStoreApp.Library.Services.Base;

namespace BookStoreApp.Library.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync(LoginUserDto loginModel);

        public Task Logout();
    }
}
