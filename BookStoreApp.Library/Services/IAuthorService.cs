using BookStoreApp.Library.Services.Base;

namespace BookStoreApp.Library.Services
{
    public interface IAuthorService
    {
        Task<Response<List<AuthorReadOnlyDto>>> GetAuthors();
    }
}