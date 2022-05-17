using AutoMapper;
using BaseEcommerce.Business.Dtos;
using BaseEcommerce.WebUI.Models;

namespace BaseEcommerce.WebUI.Mappings
{
    public class MappingViewProfile : Profile
    {
        public MappingViewProfile()
        {
            CreateMap<ProductViewModel, ProductDto>().ReverseMap();
            //CreateMap<Address, AddressDto>().ReverseMap();
            //CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<AttachmentViewModel, AttachmentDto>().ReverseMap();
            CreateMap<CommentViewModel, CommentDto>().ReverseMap();
        }
       

    }
}
