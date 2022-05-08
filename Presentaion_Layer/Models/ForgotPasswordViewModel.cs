using System.ComponentModel.DataAnnotations;

namespace Presentaion_Layer.Models
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage ="Invalid Email")]
        public string Email { get; set; }
    }
}
