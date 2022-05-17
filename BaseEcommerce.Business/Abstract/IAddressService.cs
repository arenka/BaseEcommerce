using BaseEcommerce.Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEcommerce.Business.Abstract
{
    public interface IAddressService
    {
        void Add(AddressDto addressDto);
        void Delete(int addressId);
    }
}
