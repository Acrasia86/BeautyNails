using System.ComponentModel.DataAnnotations;

namespace BeautyNails.DTOs
{
    public class RegisterDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
  
        public string Password { get; set; }
        public string DisplayName { get; set; }

        [Required]
        public string UserName { get; set; }

        public DateTime BirthDay { get; set; }
    }
}
