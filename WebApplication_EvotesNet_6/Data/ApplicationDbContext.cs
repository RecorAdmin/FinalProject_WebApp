using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplication_EvotesNet_6.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Candidates> Candidates { get; set; }
        public DbSet<Voters> Voters { get; set; }
        public DbSet<VotersAllocations> VotersAllocations { get; set; }
    }
}