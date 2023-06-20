using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PlanAhead.Models;

namespace PlanAhead.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PlanAhead.Models.Event> Event { get; set; } = default!;
        public DbSet<PlanAhead.Models.Household> Household { get; set; } = default!;
    }
}