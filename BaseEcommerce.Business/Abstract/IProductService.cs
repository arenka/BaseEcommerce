using BaseEcommerce.Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEcommerce.Business.Abstract
{
    public interface IProductService
    {
        void Add(ProductDto productDto);
        void Update(ProductDto productDto);
        void Delete(int productId);
        List<ProductDto> GetAllProduct();
    }
}
