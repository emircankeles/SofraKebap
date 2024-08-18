    using AutoMapper;
using SofraKebab.DTOLayer.ProductDTO;
using SofraKebab.EntityLayer.Entities;

namespace API.Mapping
{
    public class ProductMapper : Profile
    {
        public ProductMapper()
        {
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetProductDto>().ReverseMap();
            CreateMap<Product,ResultProductwithCategory>().ReverseMap();

        }
    }
}
