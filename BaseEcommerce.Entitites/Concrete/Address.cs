using BaseEcommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEcommerce.Entitites.Concrete
{
    public class Address:BaseEntity,IEntity
    {
     
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Description { get; set; }
        public string? UserId { get; set; }
    }
}
