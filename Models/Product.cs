using System.ComponentModel.DataAnnotations;

namespace BeautyNails.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        [Required]
        public string ProductName { get; set; } = string.Empty;
        [Required]
        public string ProductDescription { get; set; } = string.Empty;

        [Required]
        public string TimeToFinnish { get; set; } = string.Empty;
        [Required]
        public double Price { get; set; }
      
    }
}
