using BaseEcommerce.Core.Data.Concrete.EntityFramework;
using BaseEcommerce.Data.Abstract;
using BaseEcommerce.Entitites.Concrete;

namespace BaseEcommerce.Data.Concrete.EntityFramework
{
    public class EfAddressDal :EfEntityRepositoryBase<Address, BaseEcommerceDbContext>, IAddressDal
    {
      
    }
}
