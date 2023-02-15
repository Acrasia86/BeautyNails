using BeautyNails.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace BeautyNails.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<About> About { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<DaysOpen> DaysOpen { get; set; }
        public DbSet<Checkout> CheckOut { get; set; }
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

            builder.Entity<IdentityRole>().HasData(
            new IdentityRole { Id = "2", Name = "User", NormalizedName = "USER", ConcurrencyStamp = null }
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
                DisplayName = "Jp",
                BirthDay = DateTime.Now,
            });

            builder.Entity<AppUser>().HasData(new AppUser
            {
                Id = "2",
                UserName = "Aleksandra@mail.com",
                NormalizedUserName = "ALEKSANDRA@MAIL.COM",
                Email = "Aleksandra@mail.com",
                NormalizedEmail = "ALEKSANDRA@MAIL.COM",
                EmailConfirmed = true,
                PasswordHash = passwordHasher.HashPassword(null, "Password11"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                Bio = "Blabla",
                DisplayName = "Los"
            });

            builder.Entity<AppUser>().HasData(new AppUser
            {
                Id = "3",
                UserName = "User@mail.com",
                NormalizedUserName = "USER@MAIL.COM",
                Email = "User@mail.com",
                NormalizedEmail = "USER@MAIL.COM",
                EmailConfirmed = true,
                PasswordHash = passwordHasher.HashPassword(null, "Password1!"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                Bio = "Blabla",
                DisplayName = "User"
            });

            builder.Entity<AppUser>().HasData(new AppUser
            {
                Id = "4",
                UserName = "Henrik@mail.com",
                NormalizedUserName = "HENRIK@MAIL.COM",
                Email = "Henrik@mail.com",
                NormalizedEmail = "HENRIK@MAIL.COM",
                EmailConfirmed = true,
                PasswordHash = passwordHasher.HashPassword(null, "Password1!"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                Bio = "Blabla",
                DisplayName = "Henke",
                BirthDay = DateTime.Today
            });

            builder.Entity<AppUser>().HasData(new AppUser
            {
                Id = "5",
                UserName = "Kalle@mail.com",
                NormalizedUserName = "KALLE@MAIL.COM",
                Email = "Kalle@mail.com",
                NormalizedEmail = "KALLE@MAIL.COM",
                EmailConfirmed = true,
                PasswordHash = passwordHasher.HashPassword(null, "Password1!"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                Bio = "Blabla",
                DisplayName = "Kallan",
                BirthDay = DateTime.Today
            });


            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "1",
                UserId = "1"
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "1",
                UserId = "2"
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "2",
                UserId = "3"
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "2",
                UserId = "4"
            });

            builder.Entity<Product>().HasData(
                
                new Product { Id = Guid.NewGuid(),  Price = 22, ProductDescription = "Nagellack som är coolt", ProductName = "Nagellack", TimeToFinnish = "60" },
                new Product { Id = Guid.NewGuid(), Price = 300, ProductDescription = "Manikyr för coola män", ProductName = "Manikyr", TimeToFinnish = "30" },
                new Product { Id = Guid.NewGuid(), Price = 150, ProductDescription = "Mer volym för dina fransar", ProductName = "Volymfransar", TimeToFinnish = "90" },
                new Product { Id = Guid.NewGuid(), Price = 200, ProductDescription = "Om du vill ha ont och betala för det", ProductName = "Massage", TimeToFinnish = "120" },
                new Product { Id = Guid.NewGuid(), Price = 600, ProductDescription = "Test1", ProductName = "Test1", TimeToFinnish = "100" },
                new Product { Id = Guid.NewGuid(), Price = 190, ProductDescription = "Test2", ProductName = "Test2", TimeToFinnish = "50" }
                );
        }

      
    }
}
