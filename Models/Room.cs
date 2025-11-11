using System.ComponentModel.DataAnnotations;

namespace HotelHub.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string RoomType { get; set; } // Example: Single, Double, Suite

        [Required]
        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }
    }
}