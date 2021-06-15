using AutoMapper;
using ShoppingCardGrpc.Protos;

namespace ShoppingCardGrpc.Mapper
{
    public class ShoppingCartProfile : Profile
    {
        public ShoppingCartProfile()
        {
            CreateMap<Models.ShoppingCart, ShoppingCartModel>().ReverseMap();
            CreateMap<Models.ShoppingCartItem, ShoppingCartItemModel>().ReverseMap();
        }
    }
}
