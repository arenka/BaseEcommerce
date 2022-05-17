using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEcommerce.Business.Dtos
{
    public class AddressDto
    {
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Description { get; set; }
        public string? UserId { get; set; }
    }
}
