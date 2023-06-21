using System.ComponentModel.DataAnnotations.Schema;

namespace PlanAhead.Models
{
    public class Contribution
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsClaimed { get; set; }

        [ForeignKey("Event")]
        public int EventId { get; set; }

        [ForeignKey("ApplicationUser")]
        public int ClaimerId { get; set; }

        public Contribution() { }
    }
}
