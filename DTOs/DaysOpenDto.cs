using System.ComponentModel.DataAnnotations;

namespace BeautyNails.DTOs
{
    public class DaysOpenDto
    {
        public int Id { get; set; }
        [Required]
        public string DaysAndTimeOpen { get; set; } = string.Empty;
    }
}
