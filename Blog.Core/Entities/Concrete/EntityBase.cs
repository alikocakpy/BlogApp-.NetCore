using Blog.Core.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Entities
{
    public class EntityBase : IEntityBase
    {
        public EntityBase() 
        { 
            this.Id = Guid.NewGuid();
            this.CreatedDate = DateTime.Now;
            this.IsDeleted = false;
        }
        public Guid Id { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual string? ModifiedBy { get; set; }
        public virtual string? DeletedBy { get; set; }
        public virtual DateTime CreatedDate { get; set;}
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public virtual bool IsDeleted { get; set; }

    }
}
