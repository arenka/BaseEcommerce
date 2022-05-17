
using BaseEcommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEcommerce.Entitites.Concrete
{
    public class Comment : BaseEntity, IEntity
    {
     
        public string? Descrpition { get; set; }
        public string? UserId { get; set; }
        public int? ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
