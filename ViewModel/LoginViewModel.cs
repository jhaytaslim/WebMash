using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMash.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        [DisplayName("User name")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("Password")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
