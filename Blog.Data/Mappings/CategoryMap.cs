using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    internal class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("EE0433D7-CA05-4923-9351-3A6DEE2FDE0F"),
                Name = "Category 1",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Category
            {
                Id = Guid.Parse("0CD944D0-911C-4269-B527-4DF9AFBCB3E7"),
                Name = "Category 2",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            });
        }
    }
}
