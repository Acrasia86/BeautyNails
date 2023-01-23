using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace BeautyNails.Models
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        public IEnumerable<DaysOpen> DaysOpen { get; set; } = new List<DaysOpen>();

        [Required] public string Email { get; set; } = string.Empty;
        [Required] public string PhoneNumber { get; set; } = string.Empty;
        [Required] public string Address { get; set; } = string.Empty;
        [Required] public string AboutCompany { get; set; } = string.Empty;

    }
}
