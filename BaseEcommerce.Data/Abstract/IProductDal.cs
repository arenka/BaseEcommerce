using BaseEcommerce.Core.Data;
using BaseEcommerce.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEcommerce.Data.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
