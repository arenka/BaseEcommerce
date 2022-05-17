
using BaseEcommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEcommerce.Entitites.Concrete
{
    public class Product : BaseEntity, IEntity
    {
        public Product()
        {
            Comments = new List<Comment>();
        }

        public string? Name { get; set; }
        public string? Color { get; set; }
        public string? Size { get; set; }
        public int Discount { get; set; }
        public double Price { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual Attachment Attachment { get; set; }
    }
}
