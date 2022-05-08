using System.ComponentModel.DataAnnotations;

namespace Presentaion_Layer.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage ="Invalid Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.Password)]
        [MinLength(4,ErrorMessage ="Minimum length of password is 4 chars")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.Password)]
        [MinLength(4, ErrorMessage = "Minimum length of password is 4 chars")]
        [Compare("Password", ErrorMessage ="Confirm Password doesn't match the password")]
        public string ConfirmPassword { get; set; }
        public bool IsAgree { get; set; }



    }
}
