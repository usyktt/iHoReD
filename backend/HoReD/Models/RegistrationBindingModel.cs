using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HoReD.Models
{
    public class RegistrationBindingModel
    {
        [Required]
        [RegularExpression(@"[A-Za-z]{2,30}")]
        public string FirstName { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z]{2,30}")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(40)]
        public string Email { get; set; }

        [Required]
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,30}$")]
        public string Password { get; set; }

    }
}