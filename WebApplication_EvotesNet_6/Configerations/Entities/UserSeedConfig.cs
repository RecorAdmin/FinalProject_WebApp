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
                       Id = "798302a7-46d3-4m72-aina-00ee2e5f7e55",
                       Email = "admin@localhost.com",
                       NormalizedEmail = "ADMIN@LOCALHOST.COM",
                       NormalizedUserName = "ADMIN@LOCALHOST.COM",
                       UserName = "admin@localhost.com",
                       PasswordHash = hasher.HashPassword(null, "P@$$w0rd11"),
                       EmailConfirmed = true,
               },
                new IdentityUser
                {
                    Id = "af1302f7-46d3-4a72-acda-00ee2e5f7e55",
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