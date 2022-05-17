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
    public class AddressService : IAddressService
    {
        private readonly IAddressDal _addressDal;
        private readonly IMapper _mapper;

        public AddressService(IAddressDal addressDal, IMapper mapper)
        {
            _addressDal = addressDal;
            _mapper = mapper;
        }

        public void Add(AddressDto addressDto)
        {
            var address = _mapper.Map<Address>(addressDto);
            _addressDal.Add(address);
        }

        public void Delete(int addressId)
        {
            _addressDal.Delete(new Address { Id = addressId });
        }
    }
}
