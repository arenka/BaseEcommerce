using BaseEcommerce.Core.Data;
using BaseEcommerce.Data.Concrete;
using BaseEcommerce.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEcommerce.Data.Abstract
{
    public interface IAddressDal : IEntityRepository<Address>
    {
    }
}
