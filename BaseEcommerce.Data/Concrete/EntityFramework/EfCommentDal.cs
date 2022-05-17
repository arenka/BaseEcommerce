using BaseEcommerce.Data.Abstract;
using BaseEcommerce.Entitites.Concrete;
using BaseEcommerce.Core.Data.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEcommerce.Data.Concrete.EntityFramework
{
    public class EfCommentDal : EfEntityRepositoryBase<Comment, BaseEcommerceDbContext>, ICommentDal
    {
    }
}
