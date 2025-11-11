using System.ComponentModel.DataAnnotations;

namespace HotelHub.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public required string Username { get; set; }

        [Required]
        [StringLength(255)]
        public required string PasswordHash { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        public required string Role { get; set; } // Example: "Customer", "Admin"

        // New fields
        [Phone]
        public string? PhoneNumber { get; set; }

        public bool IsMfaEnabled { get; set; } // Multi-Factor Authentication
    }
}