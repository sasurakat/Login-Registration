using System;
using System.ComponentModel.DataAnnotations;

namespace LoginPage.DB.Entities
{
    public class UserAccount
    {
        [ScaffoldColumn(false)]
        public string id { get; set; }

        [Required(ErrorMessage = "Email Field Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
