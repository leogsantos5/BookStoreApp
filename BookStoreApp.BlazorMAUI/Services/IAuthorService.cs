using BookStoreApp.BlazorMAUI.Services.Base;

namespace BookStoreApp.BlazorMAUI.Services
{
    public interface IAuthorService
    {
        Task<Response<List<AuthorReadOnlyDto>>> GetAuthors();
    }
}