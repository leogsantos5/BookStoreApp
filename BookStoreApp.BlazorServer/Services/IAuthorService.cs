using BookStoreApp.BlazorServer.Services.Base;

namespace BookStoreApp.BlazorServer.Services
{
    public interface IAuthorService
    {
        Task<Response<List<AuthorReadOnlyDto>>> GetAuthors();

        Task<Response<AuthorReadOnlyDto>> GetAuthor(int id);
        Task<Response<int>> CreateAuthor(AuthorCreateDTO author);

        Task<Response<int>> EditAuthor(int id, AuthorUpdateDto author);

    }
}