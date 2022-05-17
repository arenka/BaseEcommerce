using AutoMapper;
using BaseEcommerce.Business.Abstract;
using BaseEcommerce.Business.Dtos;
using BaseEcommerce.Data.Abstract;
using BaseEcommerce.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEcommerce.Business.Concrete
{
    public class AttachmentService : IAttachmentService
    {
        private readonly IAttachmentDal _attachmentDal;
        private readonly IMapper _mapper;

        public AttachmentService(IAttachmentDal attachmentDal, IMapper mapper)
        {
            _attachmentDal = attachmentDal;
            _mapper = mapper;
        }

        public void Add(AttachmentDto attachmentDto)
        {
            var attachment = _mapper.Map<Attachment>(attachmentDto);
            _attachmentDal.Add(attachment);
        }

        public void Delete(int attachmentId)
        {
            _attachmentDal.Delete(new Attachment { Id = attachmentId });
        }
    }
}
