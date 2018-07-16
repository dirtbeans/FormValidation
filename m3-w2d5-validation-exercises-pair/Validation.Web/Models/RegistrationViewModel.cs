using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation.Web.Models
{
    public class RegistrationViewModel
    {
        [Required]
        [MaxLength(20, ErrorMessage = "First Name cannot be longer than 20 characters")]
        public string FirstName { get; set;  }

        [Required]
        [MaxLength(20, ErrorMessage = "Last name cannot be longer than 20 characters")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Must enter a vaild email address")]
        public string Email { get; set; }

        [Required]
        [Compare("Email", ErrorMessage = "Emails must match")]
        public string ConfirmEmail { get; set; }

        [Required]
        [MinLength(8, ErrorMessage ="Password must be 8 characters or more")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords must match")]
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.DateTime, ErrorMessage = "Must enter a valid date")]
        public DateTime Birthday { get; set; }

        [Required]
        [Range(1,10, ErrorMessage = "Number of tickets must be between 1 and 10")]
        public int Tickets { get; set; }
    }
}