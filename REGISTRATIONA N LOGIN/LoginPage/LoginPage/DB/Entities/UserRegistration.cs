using System;
using System.ComponentModel.DataAnnotations;

namespace LoginPage.DB.Entities
{
    public class UserRegistration
    {
             public Guid Id { get; set; }= Guid.NewGuid();
       
            [Required(ErrorMessage = "The FirstName field is required.")]
            public string FirstName { get; set; }

            [Required(ErrorMessage = "The LastName field is required.")]
            public string LastName { get; set; }

            [Required(ErrorMessage = "The Email field is required.")]
            [RegularExpression(@"^[a-zA-Z0-9''-''.\s]{1,40}$", ErrorMessage = "The Email field contains invalid characters.")]
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public DateTime DOB { get; set; }

        [Required(ErrorMessage = "The Password field is required.")]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmedPassword { get; set; }
    }
}
