using System.ComponentModel.DataAnnotations.Schema;

namespace PlanAhead.Models
{
    public class Wish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("ApplicationUser")]
        public int UserId { get; set; }
        public string Url { get; set; }
        
        public bool IsClaimed { get; set; }

        [ForeignKey("ApplicationUser")]
        public int ClaimerId { get; set; }
        public Wish() { }

    }
}
