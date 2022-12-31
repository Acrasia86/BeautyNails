using BeautyNails.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Reflection.Emit;

namespace BeautyNails.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<About> About { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<DaysOpen> DaysOpen { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
             new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp = null }
             );

            var passwordHasher = new PasswordHasher<AppUser>();
           
                builder.Entity<AppUser>().HasData(new AppUser
                {
                    Id = "1",
                    UserName = "Jacob@mail.com",
                    NormalizedUserName = "JACOB@MAIL.COM",
                    Email = "Jacob@mail.com",
                    NormalizedEmail = "JACOB@MAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null, "Password1!"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                    Bio = "Blabla",
                    DisplayName = "Jp"
                });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "1",
                UserId = "1"
            });

        }

      
    }
}
