using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RSWEBProekt_v1.Data;
using RSWEBProekt_v1.Models;
using RSWEBProekt_v1.ViewModels;

namespace RSWEBProekt_v1.Controllers
{
    public class UserManagementController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<SiteUser> userManager;

        public UserManagementController(ApplicationDbContext context, UserManager<SiteUser> userManager)
        {
            _context = context;
            this.userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> ListEntries()
        {
            var userId = userManager.GetUserId(HttpContext.User);
            IQueryable<Cars> allCars = _context.Cars;
            allCars = allCars.Where(s => s.SiteUserId.Equals(userId));
            var result = new UserEntries();
            List<Cars> found = new List<Cars>();
            found = await allCars.ToListAsync();
            foreach(var car in found)
            {
                result.carEntries.Add(car);
            }
            return View(result);
        }

        [HttpGet]
        public IActionResult CreateCar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCar(CreateCarViewModel model)
        {
            if(ModelState.IsValid)
            {
                var userId = userManager.GetUserId(HttpContext.User);
                Cars entry = new Cars()
                {
                    FullName = model.FullName,
                    Description = model.Description,
                    Price = model.Price,
                    ProdDate = model.ProdDate,
                    Location = model.Location,
                    SiteUserId = userId
                };
                _context.Add(entry);
                await _context.SaveChangesAsync();
                var user = await userManager.FindByIdAsync(userId);
                return RedirectToAction("ListEntries", "UserManagement");
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> EditEntryCar(int carId)
        {
            var car = await _context.Cars.Where(s => s.Id == carId).FirstOrDefaultAsync();
            EditCarViewModel model = new EditCarViewModel
            {
                Id = car.Id,
                FullName = car.FullName,
                Description = car.Description,
                Price = car.Price,
                ProdDate = car.ProdDate,
                Location = car.Location,
                UserId = car.SiteUserId
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditEntryCar(EditCarViewModel model)
        {
            if(ModelState.IsValid)
            {
                var car = await _context.Cars.Where(s => s.Id == model.Id).FirstOrDefaultAsync();
                car.FullName = model.FullName;
                car.Description = model.Description;
                car.SiteUserId = model.UserId;
                car.Price = model.Price;
                car.ProdDate = model.ProdDate;
                car.Location = model.Location;
                _context.Update(car);
                await _context.SaveChangesAsync();
                return RedirectToAction("ListEntries", "UserManagement");
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteEntryCar(int carId)
        {
            var car = await _context.Cars.Where(s => s.Id == carId).FirstOrDefaultAsync();
            _context.Remove(car);
            await _context.SaveChangesAsync();
            return RedirectToAction("ListEntries", "UserManagement");
        }
    }
}