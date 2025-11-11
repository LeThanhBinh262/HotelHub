using System;
using System.ComponentModel.DataAnnotations;

namespace HotelHub.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int BookingId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        [Required]
        public string PaymentMethod { get; set; } // Example: Credit Card, PayPal
    }
}