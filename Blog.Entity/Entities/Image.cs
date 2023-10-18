using Blog.Core.Entities;

namespace Blog.Entity.Entities
{
    public class Image : EntityBase
    {
        public string Name { get; set; }
        public ICollection<Article> Articles { get; set;}
    }
}
