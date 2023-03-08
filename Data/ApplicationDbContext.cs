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
                
                new Product { Id = Guid.NewGuid(),  Price = 270, ProductDescription = "Ombre/Fransk", ProductName = "Nagellack", TimeToFinnish = "60" },
                new Product { Id = Guid.NewGuid(), Price = 300, ProductDescription = "Nagelförstärkning med gele eller akryl naturligt utan färg.", ProductName = "Manikyr", TimeToFinnish = "30" },
                new Product { Id = Guid.NewGuid(), Price = 150, ProductDescription = "Med volym fransar använder man sig av tjocklek 0,07 mm, istället för singelfransar. Tekniken med dessa supertunna fransar, är att du applicerar 2-6 st lösfransar på kundens egen frans, istället för en lösfrans. Denna metod är lika skonsam som vanliga singel fransar eftersom volymfransar är väldigt lätta och tunna fransar.", ProductName = "Volymfransar", TimeToFinnish = "90" },
                new Product { Id = Guid.NewGuid(), Price = 900, ProductDescription = "Massage hjälper kropp och själ att må bra och komma i balans. Våra massageterapeuter har flera års erfarenhet inom branschen och anpassar behandlingarna efter dina önskemål och behov. En massage, oavsett vilken variant du väljer, har en lugnande och avslappnande verkan. Med en massage blir musklerna mjukare, blodcirkulationen i kroppen förbättras och själen får ro. Med regelbunden massage kan man i det flesta fall förebygga muskelspänningar och värk.", ProductName = "Massage", TimeToFinnish = "80" },
                new Product { Id = Guid.NewGuid(), Price = 2900, ProductDescription = "Vid Microblading skapar man illusionen av ett hårstrå. Med hjälp av ett handverktyg med mikronålar i tatuerar man in pigment som sedan sitter ca 1-3 år, detta är individuellt och beror på flera faktorer som till exempel din hudtyp, din ålder och hur du sköter tatueringen.", ProductName = "Microblading", TimeToFinnish = "120" },
                new Product { Id = Guid.NewGuid(), Price = 450, ProductDescription = "Fixa fötterna", ProductName = "Pedikyr", TimeToFinnish = "30" }
                );
        }

      
    }
}
