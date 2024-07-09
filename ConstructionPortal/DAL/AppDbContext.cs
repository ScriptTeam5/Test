using ConstructionPortal.Models.DataModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ConstructionPortal.DAL
{
    public class AppDbContext : IdentityDbContext<User,Role, int>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Review> Reviews { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductColor>().HasKey(pc => new { pc.ProductId, pc.ColorId });
            modelBuilder.Entity<ProductSize>().HasKey(ps => new { ps.ProductId, ps.SizeId });
            modelBuilder.Entity<Slider>().HasData(
                new Slider
                {
                    Id = 1,
                    Name = "New Trend",
                    Title = "Summer Sale Stylish",
                    Description = "TestDescription",
                    Image = "slideshow-character2.png"
                },
                new Slider
                {
                    Id = 2,
                    Name = "Another Trend",
                    Title = "Winter Sale Fashionable",
                    Description = "AnotherDescription",
                    Image = "slideshow-character1.png"
                }
                );

            modelBuilder.Entity<AppRole>().HasData(
                new AppRole { Id = 1, Name = "Admin", NormalizedName = "ADMIN" },
                  new AppRole { Id = 2, Name = "User", NormalizedName = "USER" }
              );
            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(
              new AppUser
              {
                  Id = 1,
                  UserName = "ilkin.admin",
                  Name = "Ilkin",
                  Surname = "Novruzov",
                  PasswordHash = hasher.HashPassword(null, "Admin.1234"),
                  Email = "inovruzov2004@gmail.com",
                  EmailConfirmed = true,
                  NormalizedUserName = "ILKIN.ADMIN",
                  NormalizedEmail = "INOVRUZOV2004@GMAIL.COM",
                  LockoutEnabled = true,
                  SecurityStamp = Guid.NewGuid().ToString()
              }
              );

            modelBuilder.Entity<IdentityUserRole<int>>().HasData(
       new IdentityUserRole<int> { UserId = 1, RoleId = 1 }
   );
            base.OnModelCreating(modelBuilder);
        }
    }
}
