using BookStoreApp.BlazorWebAssembly.Services.Base;

namespace BookStoreApp.BlazorWebAssembly.Services
{
    public interface IBookService
    {
        Task<Response<List<BookReadOnlyDto>>> GetBooks();

        Task<Response<BookDetailsDto>> GetBook(int id);
        Task<Response<int>> CreateBook(BookCreateDTO author);

        Task<Response<int>> EditBook(int id, BookUpdateDto author);

        Task<Response<int>> DeleteBook(int id);

    }
}