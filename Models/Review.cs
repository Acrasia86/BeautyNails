using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyNails.Models
{
    public class Review
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
