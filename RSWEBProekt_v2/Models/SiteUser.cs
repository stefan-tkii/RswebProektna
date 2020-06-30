using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RSWEBProekt_v1.Models
{
    public class SiteUser : IdentityUser
    {
        [Required]
        [StringLength(40, ErrorMessage = "First name exceeds 40 characters.")]
        [RegularExpression("^[A-Za-z]*$", ErrorMessage ="Only alphabetical characters allowed.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Last name exceeds 50 characters.")]
        [RegularExpression("^[A-Za-z]*$", ErrorMessage = "Only alphabetical characters allowed.")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(80, ErrorMessage = "Address is too long.")]
        public string Address { get; set; }

#nullable enable
        public ICollection<Cars>? Cars { get; set; }

    }
}
