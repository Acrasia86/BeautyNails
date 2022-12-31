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

        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$", ErrorMessage = "Invalid email format.")]
        [Required] public string Email { get; set; } = string.Empty;

        [RegularExpression("^07[0-9]{8}$", ErrorMessage = "Number must start with 07 and only contain 10 digits")]
        [Required] public string PhoneNumber { get; set; } = string.Empty;
        [Required] public string Address { get; set; } = string.Empty;
        [Required] public string AboutCompany { get; set; } = string.Empty;

    }
}
