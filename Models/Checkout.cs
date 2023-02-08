using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyNails.Models
{
    public class Checkout
    {
        public Guid Id { get; set; }
        public AppUser? User { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product? Product { get; set; }
        public DateTime? BookedDate { get; set; }
        public string? Address { get; set; } = string.Empty;
        public string? ZipCode { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; } = string.Empty;

    }
}
