using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RSWEBProekt_v1.Models;

namespace RSWEBProekt_v1.Data
{
    public class ApplicationDbContext : IdentityDbContext<SiteUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cars> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Cars>().HasOne<SiteUser>(p => p.Owner)
                .WithMany(p => p.Cars).HasForeignKey(p => p.SiteUserId);
        }
    }
}
