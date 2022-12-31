using BeautyNails.Models;
using System.ComponentModel.DataAnnotations;

namespace BeautyNails.DTOs
{
    public class ReviewDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Message { get; set; } = string.Empty;
        [Required]
        public int Rating { get; set; }
        public AppUser User { get; set; }
    }
}
