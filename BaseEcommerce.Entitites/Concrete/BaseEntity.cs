using BaseEcommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEcommerce.Entitites.Concrete
{
    public class BaseEntity:IEntity
    {
        public int Id { get; set; }
        public DateTime CreDateTime { get; set; }
    }
}
