using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Title 1",
                Content = "First Title Content",
                ViewCount = 15,
                CategoryId = Guid.Parse("EE0433D7-CA05-4923-9351-3A6DEE2FDE0F"),
                ImageId = Guid.Parse("38AB58F5-E29C-4B07-8E56-84EA9B042360"),
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Article
            {
                Id = Guid.NewGuid() ,
                Title = "Title 2",
                Content = "Second Title Content",
                ViewCount = 25,
                CategoryId = Guid.Parse("0CD944D0-911C-4269-B527-4DF9AFBCB3E7"),
                ImageId = Guid.Parse("A8ED4358-AE31-460A-A510-CC916ED7E235"),
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            });
        }

    }
}
