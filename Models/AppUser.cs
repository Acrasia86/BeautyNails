using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyNails.Models
{
    public class AppUser : IdentityUser
    {
        public string? DisplayName { get; set; }
        public string? Bio { get; set; }
        public DateTime? BirthDay { get; set; }
    }
}
