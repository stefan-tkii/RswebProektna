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
            carEntries = new List<Cars>();
        }

        public List<Cars> carEntries { get; set; }
    }
}
