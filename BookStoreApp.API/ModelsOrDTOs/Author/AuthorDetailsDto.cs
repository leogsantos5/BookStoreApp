using BookStoreApp.API.ModelsOrDTOs.Book;

namespace BookStoreApp.API.ModelsOrDTOs.Author
{
    public class AuthorDetailsDto : AuthorReadOnlyDto
    {
        public List<BookReadOnlyDto> Books { get; set; }
    }
}
