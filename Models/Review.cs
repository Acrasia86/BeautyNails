using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyNails.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string? Message { get; set; }
        public int? Rating { get; set; }
        public int UserId { get; set; }
        //[ForeignKey("UserId")]
        //public AppUser User { get; set; }
    }
}
