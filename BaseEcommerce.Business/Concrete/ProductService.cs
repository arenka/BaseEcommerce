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

    public class ProductService : IProductService
    {
        private readonly IProductDal _productDal;
        private readonly ICommentDal _commentDal;
        private readonly IAttachmentDal _attachmentDal;
        private readonly IMapper _mapper;

        public ProductService(IProductDal productDal, ICommentDal commentDal, IAttachmentDal attachmentDal, IMapper mapper)
        {
            _productDal = productDal;
            _mapper = mapper;
            _commentDal = commentDal;
            _attachmentDal = attachmentDal;
        }

        public void Add(ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            _productDal.Add(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(new Product { Id = productId });
        }

        public List<ProductDto> GetAllProduct()
        {
            var products = _productDal.GetList();
            if (products.Any())
            {
                foreach (var product in products)
                {
                    var attachment = _attachmentDal.Get(x => x.ProductId == product.Id);
                    if (attachment != null)
                    {
                        product.Attachment = attachment;
                    }
                    var comments = _commentDal.GetList(x => x.ProductId == product.Id);
                    if (comments.Any())
                    {
                        product.Comments = comments;
                    }
                }

            }
            return _mapper.Map<List<ProductDto>>(products);
        }

        public void Update(ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            _productDal.Update(product);
        }
    }
}
