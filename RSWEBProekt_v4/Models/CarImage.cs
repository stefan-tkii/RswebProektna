using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSWEBProekt_v1.Models
{
    public class CarImage
    {
        public CarImage()
        {

        }

        public int Id { get; set; }

        public string filePath { get; set; }

        public string fullPath { get; set; }

        public int carId { get; set; }

        public Cars Car { get; set; }
    }
}
