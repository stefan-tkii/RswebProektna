using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RSWEBProekt_v1.Models
{
    public class Cars
    {
        public Cars()
        {

        }

        public int Id { get; set; }

        [Required(ErrorMessage ="Car name and model name is required.")]
        [Display(Name ="Car's name and model")]
        [StringLength(60, ErrorMessage ="Name/model is too long.")]
        public string FullName { get; set; }

        [Required(ErrorMessage ="Product's description is required.")]
        [StringLength(255, ErrorMessage ="Description is too long.")]
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage ="Price is required")]

        public float Price { get; set; }

        [Required(ErrorMessage ="Production date is required.")]
        [DataType(DataType.Date)]
        [Display(Name ="Production date")]
        public DateTime ProdDate { get; set; }

        [Required(ErrorMessage ="Location is required.")]
        [Display(Name ="Address of vehicle")]
        public string Location { get; set; }

#nullable enable
        public string? SiteUserId { get; set; }

#nullable enable
        public SiteUser? Owner { get; set; }

#nullable enable 
        public ICollection<CarCart> InCart { get; set; }
    }
}
