
using System.ComponentModel.DataAnnotations;
using UserRegistrationFormwithValidations.Attributes;

namespace UserRegistrationFormwithValidations.Models
{
    public class SignupViewModel
    {
        [Required(ErrorMessage ="Name Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email Required")]
        [EmailAddress(ErrorMessage = "Please Enter Correct Email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Password Required")]
        [MinLength(8,ErrorMessage ="Password must be at least 8 character long")]
        [RegularExpression("([a-zA-Z]{1,})([@$!%*#?&]{1,})([0-9]{1,})",ErrorMessage = "1 Uppercase, 1 Number, 1 Special Char, and 1 Lowercase Char Required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm-Password Required")]
        [Compare("Password",ErrorMessage ="Confirm Password Doesn't Match")]
        public string ConfirmPassword { get; set; }

        [RegularExpression("^[6789]\\d{9}",ErrorMessage = "Please enter correct contact")]
        public string? Contact { get; set; }

        [Required(ErrorMessage = "Plase select gender")]
        public String Gender { get; set; }

        [ValidateCheckbox(ErrorMessage = "Please accept the terms")]
        public bool Accept { get; set; }      


    }
}
