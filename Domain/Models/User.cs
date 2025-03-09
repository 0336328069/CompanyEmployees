using Microsoft.AspNetCore.Identity;

namespace Domain.Models
{
    public class User : IdentityUser
    {
        public string Role { get; set; } = null!; // Thuộc tính tùy chỉnh, có thể null hoặc khởi tạo mặc định
    }
}