using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RSWEBProekt_v1.Models
{
    public class CarCart
    {
        public CarCart()
        {

        }

        public int Id { get; set; }

        public string userId { get; set; }
        public SiteUser siteUser { get; set; }

        public int carId { get; set; }
        public Cars car { get; set; }

        [DataType(DataType.Currency, ErrorMessage ="Invalid price format.")]
        [Required]
        public float RequestPrice { get; set; }

        [Required]
        [RegularExpression("^[0-9]{9}$", ErrorMessage ="Invalid phone number format.")]
        public string Telephone { get; set; }

        [DataType(DataType.Date)]
        public DateTime? MeetDate { get; set; }
    }
}
