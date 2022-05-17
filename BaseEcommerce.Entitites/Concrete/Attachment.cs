using BaseEcommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEcommerce.Entitites.Concrete
{
    public class Attachment:BaseEntity,IEntity
    {
      
        public string? AttachmentUrl { get; set; }
        public int? ProductId { get; set; }

        public virtual Product? Product { get; set; }
    }
}
