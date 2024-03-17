using System.ComponentModel.DataAnnotations;

namespace chat_app_authentication.Models
{
    public class Register
    {
        [Required(ErrorMessage = "User Name is required!")]
        public required string UserName { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        public required string Password { get; set; }
    }
}
