using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEcommerce.Business.Dtos
{
    public class OrderDto
    {
        public AddressDto? Address { get; set; }
        public string? UserId { get; set; }
        public virtual ICollection<ProductDto>? Products { get; set; }
    }
}
