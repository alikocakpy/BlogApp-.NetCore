using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("443B2355-AB33-4AA0-B45C-7FF53A21D738"),
                RoleId = Guid.Parse("3FDA26AA-7900-470C-BD41-D885ED911B5F")
            },
            new AppUserRole
            {
                UserId = Guid.Parse("7B455A65-AD54-40C0-86C9-70AECA8ECB80"),
                RoleId = Guid.Parse("9824E1C0-C194-4AD3-A70F-E11EFCC6A8FD")
            });
        }
    }
}
