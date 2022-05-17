using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEcommerce.Business.Dtos
{
    public class AttachmentDto
    {
        public string? AttachmentUrl { get; set; }
        public int? ProductId { get; set; }

        public virtual ProductDto? Product { get; set; }
    }
}
