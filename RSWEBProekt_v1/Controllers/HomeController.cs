using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using RSWEBProekt_v1.Data;
using RSWEBProekt_v1.Models;
using PagedList;
using PagedList.Mvc;

namespace RSWEBProekt_v1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<SiteUser> userManager;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, UserManager<SiteUser> userManager)
        {
            _logger = logger;
            _context = context;
            this.userManager = userManager;
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index(int? page, string? SearchQuery)
        {
            IQueryable<Cars> allCars = _context.Cars;
            if (!String.IsNullOrEmpty(SearchQuery))
            {
                allCars = allCars.Where(s => s.FullName.Contains(SearchQuery));
            }
            var result = allCars.ToList().ToPagedList(page ?? 1, 5);
            return View(result);
        }

        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [AllowAnonymous]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
