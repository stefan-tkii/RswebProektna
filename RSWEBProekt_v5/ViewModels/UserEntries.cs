using RSWEBProekt_v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSWEBProekt_v1.ViewModels
{
    public class UserEntries
    {
        public UserEntries()
        {
            
        }

        public int Id { get; set; }

        public string FullName { get; set; }

       
        public string Description { get; set; }

       

        public float Price { get; set; }

        
        public DateTime ProdDate { get; set; }

       
        public string Location { get; set; }


        public string ImagePath { get; set; }

    }
}
