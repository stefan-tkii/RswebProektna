using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using RSWEBProekt_v1.Models;

namespace RSWEBProekt_v1.ViewModels
{
    public class HomePageViewModel
    {
        public HomePageViewModel()
        {

        }

        public SelectList Type { get; set; }

        public IList<Cars> CarsList { get; set; }

        public string SearchQuery { get; set; }
    }
}
