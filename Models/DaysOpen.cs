using System.ComponentModel.DataAnnotations;

namespace BeautyNails.Models
{
    public class DaysOpen
    {
        public int Id { get; set; }
        [Required]
        public string DaysAndTimeOpen { get; set; } = string.Empty;
    }
}
