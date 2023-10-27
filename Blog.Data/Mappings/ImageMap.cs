using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    internal class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(
                new Image
                {
                    Id = Guid.Parse("38AB58F5-E29C-4B07-8E56-84EA9B042360"),
                    FileName = "images/image1",
                    FileType = "jpg",
                    CreatedBy = "Admin",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Image
                {
                    Id = Guid.Parse("A8ED4358-AE31-460A-A510-CC916ED7E235"),
                    FileName = "images/image2",
                    FileType = "jpg",
                    CreatedBy = "Admin",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                }
            );
        }
    }
}
