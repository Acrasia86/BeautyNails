using BeautyNails.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyNails.DTOs
{
    public class CheckoutDto
    {
        public Guid? Id { get; set; }
        public Guid ProductId { get; set; }
        public DateTime? BookedDate { get; set; }
        public string Email { get; set; }
        [Required]
        public string Address { get; set; } = string.Empty;
        [Required]
        public string ZipCode { get; set; } = string.Empty;
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
