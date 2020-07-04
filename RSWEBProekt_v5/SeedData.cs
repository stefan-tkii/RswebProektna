using RSWEBProekt_v1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using RSWEBProekt_v1.Models;
using Microsoft.EntityFrameworkCore;

namespace RSWEBProekt_v1
{
    public class SeedData
    {
        public static async void Initialize(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                string[] roles = new string[] { "Admin", "User" };
                foreach (string role in roles)
                {
                    var roleStore = new RoleStore<IdentityRole>(context);
                    if (!context.Roles.Any(r => r.Name == role))
                    {
                        var resultceo = await roleStore.CreateAsync(new IdentityRole(role)
                        {
                            NormalizedName = role.ToUpper()
                        });
                        if (resultceo.Succeeded)
                        {
                            System.Diagnostics.Debug.WriteLine("Succsess");
                        }
                        else
                        {
                            foreach (var error in resultceo.Errors)
                            {
                                System.Diagnostics.Debug.WriteLine(error.Description);
                            }
                        }
                    }
                }

                string iDate = "05-05-2005";
                var user = new SiteUser
                {
                    FirstName = "Zoko",
                    LastName = "Zoci",
                    UserName = "Admin01",
                    Email = "administrator_website@gmail.com",
                    BirthDate = DateTime.Parse(iDate),
                    Address = "Golema Reka br 42",
                    NormalizedEmail = "ADMINISTRATOR_WEBSITE@GMAIL.COM",
                    NormalizedUserName = "ADMIN01",
                    PhoneNumber = "+111111111111",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };
    
                if (!context.Users.Any(u => u.UserName == user.UserName))
                {
                    var password = new PasswordHasher<SiteUser>();
                    var hashed = password.HashPassword(user, "Jassumadmin01");
                    user.PasswordHash = hashed;

                    var userStore = new UserStore<SiteUser>(context);
                    var result = await userStore.CreateAsync(user);

                    UserManager<SiteUser> _userManager = scope.ServiceProvider.GetRequiredService<UserManager<SiteUser>>();
                    SiteUser userce = await _userManager.FindByEmailAsync(user.Email);
                    var resultce = await _userManager.AddToRoleAsync(userce, roles[0]);
                }

                await context.SaveChangesAsync();

            }
        }
    }
}
