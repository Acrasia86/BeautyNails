using System.ComponentModel.DataAnnotations;

namespace BeautyNails.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; } = string.Empty;
        [Required]
        public string ProductDescription { get; set; } = string.Empty;

        [Required]
        public string TimeToFinnish { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        [Required]
        public double Price { get; set; }
    }
}
