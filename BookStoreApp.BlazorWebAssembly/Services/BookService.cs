using Blazored.LocalStorage;
using BookStoreApp.BlazorWebAssembly.Services.Base;

namespace BookStoreApp.BlazorWebAssembly.Services
{
    public class BookService : BaseHttpService, IBookService
    {
        private readonly IClient client;

        public BookService(IClient client, ILocalStorageService localStorageService) : base(client, localStorageService)
        {
            this.client = client;
        }

        public async Task<Response<List<BookReadOnlyDto>>> GetBooks()
        {
            Response<List<BookReadOnlyDto>> response;

            try
            {
                await GetBearerToken();
                var data = await client.BooksAllAsync();
                response = new Response<List<BookReadOnlyDto>>
                {
                    Data = data.ToList(),
                    Success = true
                };
            }
            catch (ApiException apiException)
            {
                response = ConvertApiExceptions<List<BookReadOnlyDto>>(apiException);
            }

            return response;
        }

        public async Task<Response<BookDetailsDto>> GetBook(int id)
        {
            Response<BookDetailsDto> response;

            try
            {
                var data = await client.BooksGETAsync(id);
                response = new Response<BookDetailsDto>
                {
                    Data = data,
                    Success = true
                };
            }
            catch (ApiException apiException)
            {
                response = ConvertApiExceptions<BookDetailsDto>(apiException);
            }

            return response;
        }

        public async Task<Response<int>> CreateBook(BookCreateDTO Book)
        {
            Response<int> response = new();

            try
            {
                await GetBearerToken();
                await client.BooksPOSTAsync(Book);
            }
            catch (ApiException apiException)
            {
                response = ConvertApiExceptions<int>(apiException);
            }

            return response;
        }

        public async Task<Response<int>> EditBook(int id, BookUpdateDto Book)
        {
            Response<int> response = new();

            try
            {
                await GetBearerToken();
                await client.BooksPUTAsync(id, Book);
            }
            catch (ApiException apiException)
            {
                response = ConvertApiExceptions<int>(apiException);
            }

            return response;
        }

        public async Task<Response<int>> DeleteBook(int id)
        {
            Response<int> response = new();

            try
            {
                await GetBearerToken();
                await client.BooksDELETEAsync(id);
            }
            catch (ApiException apiException)
            {
                response = ConvertApiExceptions<int>(apiException);
            }

            return response;
        }
    }
}
