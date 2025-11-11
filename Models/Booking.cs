using System;
using System.ComponentModel.DataAnnotations;

namespace HotelHub.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int RoomId { get; set; }

        [Required]
        public DateTime CheckInDate { get; set; }

        [Required]
        public DateTime CheckOutDate { get; set; }

        [Required]
        public string Status { get; set; } // Example: Confirmed, Cancelled

        [Required]
        [StringLength(100)]
        public required string CustomerName { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Total amount must be greater than zero.")]
        public decimal TotalAmount { get; set; }

        [Required]
        public bool IsPaid { get; set; }
    }
}