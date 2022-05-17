using BaseEcommerce.Data.Abstract;
using BaseEcommerce.Core.Data.Concrete.EntityFramework;
using BaseEcommerce.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEcommerce.Data.Concrete.EntityFramework
{
    public class EfAttachmentDal : EfEntityRepositoryBase<Attachment,BaseEcommerceDbContext>, IAttachmentDal
    {
      
    }
}
