using System.ComponentModel.DataAnnotations;

namespace chat_app_authentication.Models
{
    public class Login
    {
        [Required(ErrorMessage ="User Name is required!")]
        public required string UserName { get; set; }

        [Required(ErrorMessage ="Password is required!")]
        public required string Password { get; set; }
    }
}
