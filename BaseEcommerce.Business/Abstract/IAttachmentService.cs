using BaseEcommerce.Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEcommerce.Business.Abstract
{
    public interface IAttachmentService
    {
        void Add(AttachmentDto attachmentDto);
        void Delete(int attachmentId);
    }
}
