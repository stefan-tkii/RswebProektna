using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RSWEBProekt_v1.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(40, ErrorMessage = "First name exceeds 40 characters.")]
        [RegularExpression("^[A-Za-z]*$", ErrorMessage = "Only alphabetical characters allowed.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Last name exceeds 50 characters.")]
        [RegularExpression("^[A-Za-z]*$", ErrorMessage = "Only alphabetical characters allowed.")]
        public string LastName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Username exceeds 20 characters.")]
        [RegularExpression("[A-Za-z][A-Za-z0-9._]{5,20}", ErrorMessage = "Invalid username format. Minimum character length is 5.")]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Confirm password")]
        [Compare("Password", ErrorMessage ="Password doesn't match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(80, ErrorMessage = "Address is too long.")]
        public string Address { get; set; }

    }
}
