using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation.Web.Models
{
    public class LoginViewModel
    {
        [DataType(DataType.EmailAddress, ErrorMessage = "Must be a valid email")]
        public string Email { get; set; }

        [DataType(DataType.Password, ErrorMessage = "Incorrect Password")]
        public string Password { get; set; }
    }
}