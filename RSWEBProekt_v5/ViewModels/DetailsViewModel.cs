using RSWEBProekt_v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSWEBProekt_v1.ViewModels
{
    public class DetailsViewModel
    {
        public DetailsViewModel()
        {

        }

        public int Id { get; set; }
       
        public string FullName { get; set; }

        public string Description { get; set; }

        public float Price { get; set; }
     
        public DateTime ProdDate { get; set; }

        public string Location { get; set; }

        public string? SiteUserId { get; set; }

        public string OwnerUsername { get; set; }

        public string OwnerFirstName { get; set; }

        public string OwnerLastName { get; set; }

        public string? ImagePath { get; set; }
    }
}
