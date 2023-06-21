using Microsoft.AspNetCore.Identity;

namespace PlanAhead.Models
{
    public class NoAccountUser : IdentityUser
    {
        public int Id { get; set; }
        public int HousholdID { get; set; }
        public string FirstName { get; set; }

        public NoAccountUser()
        {

        }
    }
}
