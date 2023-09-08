using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.ModelsOrDTOs.User
{
    public class UserDTO : LoginUserDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Role { get; set; }
    }
}
