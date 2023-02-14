using System.ComponentModel.DataAnnotations;
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
        [Required]
        public string Address { get; set; } = string.Empty;
        [Required]
        public string ZipCode { get; set; } = string.Empty;
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;

    }
}
