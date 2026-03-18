using System.ComponentModel.DataAnnotations;

namespace Refresher.Models.ViewModels
{
    public class CreateAccountViewModel
    {


        [Required(ErrorMessage = "Email address required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password required")]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]

        public string ConfirmPassword { get; set; }

    }
}
