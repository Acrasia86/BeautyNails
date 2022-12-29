using System.ComponentModel.DataAnnotations;

namespace BeautyNails.DTOs
{
    public class AboutDto
    {
        [Required]
        public DateTime OpeningHours { get; set; }
        [Required]
        public DateTime ClosingHours { get; set; }
        [Required] public string Email { get; set; } = string.Empty;
        [Required] public string PhoneNumber { get; set; } = string.Empty;
        [Required] public string Address { get; set; } = string.Empty;
        [Required] public string AboutCompany { get; set; } = string.Empty;
    }
}
