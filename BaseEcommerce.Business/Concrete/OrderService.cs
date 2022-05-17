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
    public class OrderService : IOrderService
    {
        private readonly IOrderDal _orderDal;
        private readonly IMapper _mapper;

        public OrderService(IOrderDal orderDal, IMapper mapper)
        {
            _orderDal = orderDal;
            _mapper = mapper;
        }

        public void Add(OrderDto orderDto)
        {
            var order = _mapper.Map<Order>(orderDto);
            _orderDal.Add(order);
        }

        public void Delete(int orderId)
        {
            _orderDal.Delete(new Order { Id = orderId });
        }
    }
}
