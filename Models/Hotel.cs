using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelHub.Models
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public required string Name { get; set; }

        [Required]
        public required string Location { get; set; }

        public ICollection<Room>? Rooms { get; set; }
    }
}