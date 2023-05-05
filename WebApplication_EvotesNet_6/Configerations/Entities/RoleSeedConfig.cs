using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication_EvotesNet_6.Configerations.Entities
{
    public class RoleSeedConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                    {
                        Id = "91978a77-54df-4663-9mi6-3712nf2788fa",
                        Name = "Admin",
                        NormalizedName = "ADMIN"
                    },
                new IdentityRole
                {
                    Id = "u2se6r1d-10d1-461e-367d-ed375e67fe6f",
                    Name = "User",
                    NormalizedName = "USER"
                }
                );
        }
    }
}