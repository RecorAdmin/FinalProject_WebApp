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
                        RoleId = "91978a77-54df-4663-9mi6-3712nf2788fa",
                        UserId = "798302a7-46d3-4m72-aina-00ee2e5f7e55"
                    },
                     new IdentityUserRole<string>
                     {
                         RoleId = "u2se6r1d-10d1-461e-367d-ed375e67fe6f",
                         UserId = "af1302f7-46d3-4a72-acda-00ee2e5f7e55"
                     }
                );
        }
    }
}