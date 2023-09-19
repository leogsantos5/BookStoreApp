using Blazored.LocalStorage;
using BookStoreApp.BlazorServer.Services.Base;
using Microsoft.AspNetCore.Authorization;

namespace BookStoreApp.BlazorServer.Services
{
    public class AuthorService : BaseHttpService, IAuthorService
    {
        private readonly IClient client;

        public AuthorService(IClient client, ILocalStorageService localStorageService) : base(client, localStorageService)
        {
            this.client = client;
        }

        public async Task<Response<List<AuthorReadOnlyDto>>> GetAuthors()
        {
            Response<List<AuthorReadOnlyDto>> response;

            try
            {
                await GetBearerToken();
                var data = await client.AuthorsAllAsync();
                response = new Response<List<AuthorReadOnlyDto>>
                {
                    Data = data.ToList(),
                    Success = true
                };
            }
            catch (ApiException apiException) 
            {
                response = ConvertApiExceptions<List<AuthorReadOnlyDto>>(apiException);
            }

            return response;
        }

        public async Task<Response<AuthorReadOnlyDto>> GetAuthor(int id)
        {
            Response<AuthorReadOnlyDto> response;

            try
            {
                var author = await client.AuthorsGETAsync(id);
                var data = new AuthorReadOnlyDto()
                { 
                    FirstName = author.FirstName,
                    LastName = author.LastName,
                    Bio = author.Bio,
                    Id = author.Id
                };
                response = new Response<AuthorReadOnlyDto> { 
                    Data = data, 
                    Success = true
                };
            }
            catch (ApiException apiException)
            {
                response = ConvertApiExceptions<AuthorReadOnlyDto>(apiException);
            }

            return response;
        }

        public async Task<Response<int>> CreateAuthor(AuthorCreateDTO author)
        {
            Response<int> response = new ();

            try
            {
                await GetBearerToken();
                await client.AuthorsPOSTAsync(author);
            }
            catch (ApiException apiException) {

                response = ConvertApiExceptions<int>(apiException);
            }

            return response;
        }

        public async Task<Response<int>> EditAuthor(int id, AuthorUpdateDto author)
        {
            Response<int> response = new();

            try
            {
                await GetBearerToken();
                await client.AuthorsPUTAsync(id, author);
            }
            catch (ApiException apiException)
            {
                response = ConvertApiExceptions<int>(apiException);
            }

            return response;
        }
    }
}
