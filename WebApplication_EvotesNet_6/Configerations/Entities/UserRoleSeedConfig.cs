using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace WebApplication_EvotesNet_6.Configerations.Entities
{
    internal class UserRoleSeedConfig : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Microsoft.AspNetCore.Identity.IdentityUserRole<string>> builder)
        {
            builder.HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = "82049c77-54af-4663-9fc6-3712cf2788fa",
                        UserId = "d2dd6a1d-10d1-461e-992d-ed375e67fe6f"
                    }
                );
        }
    }
}