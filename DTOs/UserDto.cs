using BeautyNails.Models;
using Microsoft.AspNetCore.Identity;

namespace BeautyNails.DTOs
{
    public class UserDto
    {
        public string DisplayName { get; set; }
        public string Token { get; set; }
        public string Image { get; set; }
        public string UserName { get; set; }
    }
}
