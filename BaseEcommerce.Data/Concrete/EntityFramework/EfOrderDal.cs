using BaseEcommerce.Data.Abstract;
using BaseEcommerce.Entitites.Concrete;
using System;
using BaseEcommerce.Core.Data.Concrete.EntityFramework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEcommerce.Data.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, BaseEcommerceDbContext>, IOrderDal
    {
   
    }
}
