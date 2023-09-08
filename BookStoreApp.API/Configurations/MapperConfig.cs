using AutoMapper;
using BookStoreApp.API.Data;
using BookStoreApp.API.ModelsOrDTOs.Author;
using BookStoreApp.API.ModelsOrDTOs.Book;

namespace BookStoreApp.API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorCreateDTO, Author>().ReverseMap(); 
            CreateMap<AuthorUpdateDto, Author>().ReverseMap();
            CreateMap<AuthorReadOnlyDto, Author>().ReverseMap();

            CreateMap<BookCreateDTO, Book>().ReverseMap();
            CreateMap<BookUpdateDto, Book>().ReverseMap();
            CreateMap<Book, BookReadOnlyDto>().ForMember(book => book.AuthorName, book => book.MapFrom(map => $"{map.Author.FirstName} {map.Author.LastName}")).ReverseMap();
            CreateMap<Book, BookDetailsDto>().ForMember(book => book.AuthorName, book => book.MapFrom(map => $"{map.Author.FirstName} {map.Author.LastName}")).ReverseMap();
        }
    }
}
