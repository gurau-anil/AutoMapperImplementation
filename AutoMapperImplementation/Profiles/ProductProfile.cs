using AutoMapper;
using AutoMapperImplementation.DTOs;
using AutoMapperImplementation.Entities;

namespace AutoMapperImplementation.Profiles
{
    public class ProductProfile: Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDTO>();
        }
    }
}
