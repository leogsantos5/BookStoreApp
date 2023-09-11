using BookStoreApp.BlazorServer.Services.Base;

namespace BookStoreApp.BlazorServer.Services
{
    public interface IAuthorService
    {
        Task<Response<List<AuthorReadOnlyDto>>> GetAuthors();
    }
}