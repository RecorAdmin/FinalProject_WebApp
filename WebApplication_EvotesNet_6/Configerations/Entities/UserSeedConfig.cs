using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication_EvotesNet_6.Configerations.Entities
{
    public class UserSeedConfig : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            var hasher = new PasswordHasher<IdentityUser>();
            builder.HasData(
               new IdentityUser
                   {
                       Id = "82049c77-54af-4663-9fc6-3712cf2788fa",
                       Email = "admin@localhost.com",
                       NormalizedEmail = "ADMIN@LOCALHOST.COM",
                       NormalizedUserName = "ADMIN@LOCALHOST.COM",
                       UserName = "admin@localhost.com",
                       PasswordHash = hasher.HashPassword(null, "P@$$w0rd11"),
                       EmailConfirmed = true,
               },
                new IdentityUser
                {
                    Id = "d2dd6a1d-10d1-461e-992d-ed375e67fe6f",
                    Email = "user@localhost.com",
                    NormalizedEmail = "USER@LOCALHOST.COM",
                    NormalizedUserName = "USER@LOCALHOST.COM",
                    UserName = "user@localhost.com",
                    PasswordHash = hasher.HashPassword(null, "P@$$w0rd11"),
                    EmailConfirmed = true
                }
               );
        }
    }
}