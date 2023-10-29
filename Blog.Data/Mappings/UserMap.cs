using Blog.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class UserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            // Primary key
            builder.HasKey(u => u.Id);

            // Indexes for "normalized" username and email, to allow efficient lookups
            builder.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
            builder.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");

            // Maps to the AspNetUsers table
            builder.ToTable("AspNetUsers");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.UserName).HasMaxLength(100);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(256);
            builder.Property(u => u.Email).HasMaxLength(80);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(256);

            // The relationships between User and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each User can have many UserClaims
            builder.HasMany<AppUserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();

            // Each User can have many UserLogins
            builder.HasMany<AppUserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();

            // Each User can have many UserTokens
            builder.HasMany<AppUserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();

            // Each User can have many entries in the UserRole join table
            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();


            var superadmin = new AppUser
            {
                Id = Guid.Parse("443B2355-AB33-4AA0-B45C-7FF53A21D738"),
                UserName = "alikocak@gmail.com",
                NormalizedUserName = "ALIKOCAK@GMAIL.COM",
                Email = "alikocak@gmail.com",
                NormalizedEmail = "ALIKOCAK@GMAIL.COM",
                PhoneNumber = "1234567890",
                FirstName = "Ali",
                LastName = "Koçak",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageId = Guid.Parse("38AB58F5-E29C-4B07-8E56-84EA9B042360")
            };
            superadmin.PasswordHash = CreatePassworkdHash(superadmin, "123456");

            var admin = new AppUser
            {
                Id = Guid.Parse("7B455A65-AD54-40C0-86C9-70AECA8ECB80"),
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                PhoneNumber = "1234567890",
                FirstName = "Admin",
                LastName = "yetkikli",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageId = Guid.Parse("A8ED4358-AE31-460A-A510-CC916ED7E235")
            };
            admin.PasswordHash = CreatePassworkdHash(admin, "123");

            builder.HasData(superadmin,admin);
        }
        private string CreatePassworkdHash(AppUser user, string password)
        {
            var passwordHasher = new PasswordHasher<AppUser>();
            return passwordHasher.HashPassword(user,password);
        }
    }
}
