using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication_EvotesNet_6.Configerations.Entities;

namespace WebApplication_EvotesNet_6.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfig());
            builder.ApplyConfiguration(new UserSeedConfig());
            builder.ApplyConfiguration(new UserRoleSeedConfig());
        }
        public DbSet<Candidates> Candidates { get; set; }
        public DbSet<Voters> Voters { get; set; }
        public DbSet<VotersAllocations> VotersAllocations { get; set; }
    }
}