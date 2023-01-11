using System.ComponentModel.DataAnnotations;

namespace Autentication_and_Authorization_Register_Web_API.Authentication
{
    public class RegisterModel
    {
        [Required (ErrorMessage = "UserName  is Required")]

        public string UserName { get; set; }

        [Required(ErrorMessage = "Email  is Required")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Password  is Required")]
        public string Password { get; set; }

    }
}
