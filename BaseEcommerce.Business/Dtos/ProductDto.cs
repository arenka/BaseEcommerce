using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEcommerce.Business.Dtos
{
    public class ProductDto
    {
        public string? Name { get; set; }
        public string? Color { get; set; }
        public string? Size { get; set; }
        public int Discount { get; set; }
        public double? Price { get; set; }
        public virtual ICollection<CommentDto>? Comments { get; set; }
        public virtual AttachmentDto? Attachment { get; set; }
    }
}
