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
                        Id = "82049c77-54af-4663-9fc6-3712cf2788fa",
                        Name = "Admin",
                        NormalizedName = "ADMIN"
                    },
                new IdentityRole
                {
                    Id = "d2dd6a1d-10d1-461e-992d-ed375e67fe6f",
                    Name = "User",
                    NormalizedName = "USER"
                }
                );
        }
    }
}