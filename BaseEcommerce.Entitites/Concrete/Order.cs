
using BaseEcommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEcommerce.Entitites.Concrete
{
    public class Order : BaseEntity, IEntity
    {
        public Address? Address { get; set; }
        public string? UserId { get; set; }
    }
}
