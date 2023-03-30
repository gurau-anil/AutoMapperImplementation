using AutoMapper;
using AutoMapperImplementation.DTOs;
using AutoMapperImplementation.Entities;

namespace AutoMapperImplementation.Profiles
{
    public class ProductProfile: Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDTO>()
                .ForMember(x => x.Colour, y => y.MapFrom(c => c.Color));
        }
    }
}
