using System.ComponentModel.DataAnnotations.Schema;

namespace PlanAhead.Models
{
    public class Attendee
    {
        public int Id { get; set; }
        [ForeignKey("Event")]
        public int EventId { get; set; }
        [ForeignKey("ApplicationUser")]
        public int UserId { get; set; }
    }
}
