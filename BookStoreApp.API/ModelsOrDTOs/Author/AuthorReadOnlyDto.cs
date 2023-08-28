using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.ModelsOrDTOs.Author
{
    public class AuthorReadOnlyDto : BaseDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Bio { get; set; }
    }
}
