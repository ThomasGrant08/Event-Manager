using Microsoft.AspNetCore.Identity;

namespace PlanAhead.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int HousholdId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Role { get; set; }
    }
}
