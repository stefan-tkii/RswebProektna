using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RSWEBProekt_v1.ViewModels
{
    public class EditCarViewModel
    {
        public EditCarViewModel()
        {

        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Car name and model name is required.")]
        [Display(Name = "Car's name and model")]
        [StringLength(60, ErrorMessage = "Name/model is too long.")]
        [RegularExpression("^[sa-zA-Z0-9,@_()-+]*$", ErrorMessage = "Invalid name/model format")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Product's description is required.")]
        [StringLength(255, ErrorMessage = "Description is too long.")]
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Price is required")]

        public float Price { get; set; }

        [Required(ErrorMessage = "Production date is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "Production date")]
        public DateTime ProdDate { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        [Display(Name = "Address of vehicle")]
        public string Location { get; set; }

        public string UserId { get; set; }
    }
}
