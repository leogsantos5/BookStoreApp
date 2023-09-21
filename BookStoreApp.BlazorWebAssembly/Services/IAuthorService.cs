using BookStoreApp.BlazorWebAssembly.Services.Base;

namespace BookStoreApp.BlazorWebAssembly.Services
{
    public interface IAuthorService
    {
        Task<Response<List<AuthorReadOnlyDto>>> GetAuthors();

        Task<Response<AuthorDetailsDto>> GetAuthor(int id);
        Task<Response<int>> CreateAuthor(AuthorCreateDTO author);

        Task<Response<int>> EditAuthor(int id, AuthorUpdateDto author);

        Task<Response<int>> DeleteAuthor(int id);

    }
}