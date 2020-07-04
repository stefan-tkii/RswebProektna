using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RSWEBProekt_v1.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [StringLength(20, ErrorMessage = "Username exceeds 20 characters.")]
        [RegularExpression("[A-Za-z][A-Za-z0-9._]{5,20}", ErrorMessage = "Invalid username format. Minimum character length is 5.")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Remember me")]
        public bool RememberMe { get; set; }
    }
}
