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
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["PriceSortParm"] = sortOrder == "Price" ? "price_desc" : "Price";
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            var cars = from s in _context.Cars
                       select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                cars = cars.Where(s => s.FullName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    cars = cars.OrderByDescending(s => s.FullName);
                    break;
                case "Date":
                    cars = cars.OrderBy(s => s.ProdDate);
                    break;
                case "date_desc":
                    cars = cars.OrderByDescending(s => s.ProdDate);
                    break;
                case "Price":
                    cars = cars.OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    cars = cars.OrderByDescending(s => s.Price);
                    break;
            }
            int pageSize = 5;
            return View(await PaginatedList<Cars>.CreateAsync(cars.Include(s=>s.Owner).AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        [HttpGet]
        public async Task<IActionResult> DetailsView(int itemId)
        {
            if (itemId == null)
            {
                return NotFound();
            }
            var result = await _context.Cars.Where(s => s.Id == itemId).Include(s=>s.Owner).FirstOrDefaultAsync();
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
