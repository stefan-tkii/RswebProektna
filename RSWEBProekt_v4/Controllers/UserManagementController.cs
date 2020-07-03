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
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.Web;


namespace RSWEBProekt_v1.Controllers
{
    public class UserManagementController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<SiteUser> userManager;
        private readonly IWebHostEnvironment hostEnvironment;

        public UserManagementController(ApplicationDbContext context, UserManager<SiteUser> userManager, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this.userManager = userManager;
            this.hostEnvironment = hostEnvironment;
        }

        [HttpGet]
        public async Task<IActionResult> ListEntries()
        {
            var userId = userManager.GetUserId(HttpContext.User);
            IQueryable<Cars> allCars = _context.Cars;
            allCars = allCars.Where(s => s.SiteUserId.Equals(userId));
            var result = new List<UserEntries>();
            List<Cars> found = new List<Cars>();
            found = await allCars.ToListAsync();
            ViewData["Alt"] = "~/images/imagenotfound.png";
            foreach (var car in found)
            {
                var assocImage = await _context.Images.Where(s => s.carId == car.Id).FirstOrDefaultAsync();
                if (assocImage != null)
                {
                    var item = new UserEntries()
                    {
                        Id = car.Id,
                        FullName = car.FullName,
                        Description = car.Description,
                        Price = car.Price,
                        Location = car.Location,
                        ProdDate = car.ProdDate,
                        ImagePath = assocImage.filePath
                    };
                    System.Diagnostics.Debug.WriteLine(assocImage.filePath);
                    result.Add(item);
                }
                else
                {
                    var item = new UserEntries()
                    {
                        Id = car.Id,
                        FullName = car.FullName,
                        Description = car.Description,
                        Price = car.Price,
                        Location = car.Location,
                        ProdDate = car.ProdDate
                    };
                    result.Add(item);
                }
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
                if (model.UploadedFile != null)
                {
                    var getEntry = await _context.Cars.Where(s => s.FullName.Equals(model.FullName) && s.SiteUserId == entry.SiteUserId && s.Description.Equals(entry.Description))
                        .FirstOrDefaultAsync();
                    string partialPath = Path.Combine(hostEnvironment.WebRootPath + "/images/");
                    string uniqueName = Guid.NewGuid().ToString() + model.UploadedFile.FileName;
                    string fullPather = Path.Combine(partialPath + uniqueName);
                    using (var filestream = new FileStream(fullPather, FileMode.Create))
                    {
                        model.UploadedFile.CopyTo(filestream);
                    }
                    CarImage entryImage = new CarImage()
                    {
                        filePath = "~/images/" + uniqueName,
                        carId = getEntry.Id,
                        fullPath = uniqueName
                    };
                    _context.Add(entryImage);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("ListEntries", "UserManagement");
                }
                else
                {
                    return RedirectToAction("ListEntries", "UserManagement");
                }
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
                if (model.UploadedFile != null)
                {
                    var car = await _context.Cars.Where(s => s.Id == model.Id).FirstOrDefaultAsync();
                    car.FullName = model.FullName;
                    car.Description = model.Description;
                    car.SiteUserId = model.UserId;
                    car.Price = model.Price;
                    car.ProdDate = model.ProdDate;
                    car.Location = model.Location;
                    var image = await _context.Images.Where(s => s.carId == model.Id).FirstOrDefaultAsync();
                    if(image != null)
                    {
                        string partialPath = Path.Combine(hostEnvironment.WebRootPath + "/images/");
                        string wholePath = Path.Combine(partialPath + image.fullPath);
                        if (System.IO.File.Exists(wholePath))
                        {
                            System.IO.File.Delete(wholePath);
                        }
                        string uniqueName = Guid.NewGuid().ToString() + model.UploadedFile.FileName;
                        string fullPather = Path.Combine(partialPath + uniqueName);
                        using (var filestream = new FileStream(fullPather, FileMode.Create))
                        {
                            model.UploadedFile.CopyTo(filestream);
                        }
                        image.filePath = "~/images/" + uniqueName;
                        image.fullPath = uniqueName;
                        _context.Update(image);
                        await _context.SaveChangesAsync();
                        _context.Update(car);
                        await _context.SaveChangesAsync();
                        return RedirectToAction("ListEntries", "UserManagement");
                    }
                    else
                    {
                        string partialPath = Path.Combine(hostEnvironment.WebRootPath + "/images/");
                        string uniqueName = Guid.NewGuid().ToString() + model.UploadedFile.FileName;
                        string fullPather = Path.Combine(partialPath + uniqueName);
                        using (var filestream = new FileStream(fullPather, FileMode.Create))
                        {
                            model.UploadedFile.CopyTo(filestream);
                        }
                        CarImage entryImage = new CarImage()
                        {
                            filePath = "~/images/" + uniqueName,
                            carId = car.Id,
                            fullPath = uniqueName
                        };
                        _context.Add(entryImage);
                        await _context.SaveChangesAsync();
                        _context.Update(car);
                        await _context.SaveChangesAsync();
                        return RedirectToAction("ListEntries", "UserManagement");
                    }
                }
                else
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
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteEntryCar(int carId)
        {
            var car = await _context.Cars.Where(s => s.Id == carId).FirstOrDefaultAsync();
            var assocImage = await _context.Images.Where(s => s.carId == carId).FirstOrDefaultAsync();
            if(assocImage != null)
            {
                string partialPath = Path.Combine(hostEnvironment.WebRootPath + "/images/");
                string wholePath = Path.Combine(partialPath + assocImage.fullPath);
                if(System.IO.File.Exists(wholePath))
                {
                    System.IO.File.Delete(wholePath);
                }
                _context.Remove(assocImage);
                await _context.SaveChangesAsync();
            }
            _context.Remove(car);
            await _context.SaveChangesAsync();
            return RedirectToAction("ListEntries", "UserManagement");
        }

        [HttpGet]
        public IActionResult AddCart(int carId)
        {
            ViewData["CarID"] = carId;
            System.Diagnostics.Debug.WriteLine(carId);
            var car = _context.Cars.Where(s => s.Id == carId).Include(s=>s.Owner).FirstOrDefault();
            System.Diagnostics.Debug.WriteLine(car.Id);
            var userceId = userManager.GetUserId(HttpContext.User);
            System.Diagnostics.Debug.WriteLine(userceId);
            System.Diagnostics.Debug.WriteLine(car.Owner.Id);
            if (userceId == car.Owner.Id)
            {
                return RedirectToAction("NotAllowed", "UserManagement");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCart(AddCartViewModel model)
        {
            if(ModelState.IsValid)
            {
                var userceId = userManager.GetUserId(HttpContext.User);
                CarCart entry = new CarCart
                {
                    userId = userceId,
                    carId = model.carId,
                    RequestPrice = model.RequestPrice,
                    Telephone = model.Telephone,
                    MeetDate = model.MeetDate
                };
                _context.Add(entry);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult NotAllowed()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ListCart()
        {
            var loggedId = userManager.GetUserId(HttpContext.User);
            var found = await _context.CarCarts.Where(s => s.userId == loggedId).Include(s=>s.car).ThenInclude(s=>s.Owner).ToListAsync();
            return View(found);
        }

        [HttpGet]
        public IActionResult EditCartEntry(int itemId, string name)
        {
            if(itemId == null)
            {
                return NotFound();
            }
            ViewData["itemId"] = itemId;
            ViewData["carName"] = name;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EditCartEntry(EditCartViewModel model)
        {
            if(ModelState.IsValid)
            {
                var entry = await _context.CarCarts.Where(s => s.Id == model.entryId).FirstOrDefaultAsync();
                entry.RequestPrice = model.RequestPrice;
                entry.MeetDate = model.MeetDate;
                entry.Telephone = model.Telephone;
                _context.Update(entry);
                await _context.SaveChangesAsync();
                return RedirectToAction("ListCart", "UserManagement");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCartItem(int itemId)
        {
            if(itemId == null)
            {
                return NotFound();
            }
            bool check=false;
            var loggedId = userManager.GetUserId(HttpContext.User);
            var item_check = await _context.CarCarts.Where(s => s.Id == itemId).Include(s=>s.siteUser).FirstOrDefaultAsync();
            if(loggedId == item_check.siteUser.Id)
            {
                check = true;
            }
            var item = await _context.CarCarts.Where(s => s.Id == itemId).FirstOrDefaultAsync();
            _context.Remove(item);
            await _context.SaveChangesAsync();
            if (check)
            {
                return RedirectToAction("ListCart", "UserManagement");
            }
            else
            {
                return RedirectToAction("ListRequests", "UserManagement");
            }
        }

        [HttpGet]
        public IActionResult ListRequests()
        {
            var loggedId = userManager.GetUserId(HttpContext.User);
            var userCars = _context.Cars.Where(s => s.Owner.Id == loggedId).ToList();
            List<CarCart> results = new List<CarCart>();
            foreach (var car in userCars)
            {
                var item = _context.CarCarts.Where(s => s.carId == car.Id).Include(s => s.siteUser).Include(s => s.car).ToList();
                if (item.Any())
                {
                    foreach(var inner in item)
                    {
                        results.Add(inner);
                    }
                }
            }
            return View(results);
        }
    }
}