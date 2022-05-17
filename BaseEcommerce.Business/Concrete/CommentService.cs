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
    public class CommentService : ICommentService
    {
        private readonly ICommentDal _commentDal;
        private readonly IMapper _mapper;

        public CommentService(ICommentDal commentDal, IMapper mapper)
        {
            _commentDal = commentDal;
            _mapper = mapper;
        }

        public void Add(CommentDto commentDto)
        {
            var comment = _mapper.Map<Comment>(commentDto);
            _commentDal.Add(comment);
        }

        public void Delete(int commentId)
        {
            _commentDal.Delete(new Comment { Id = commentId });
        }
    }
}
