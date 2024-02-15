using System.ComponentModel.DataAnnotations;

namespace EventOrganizer.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        [StringLength(200)]
        public string Location { get; set; }
    }
}
