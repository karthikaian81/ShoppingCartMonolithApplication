using AutoMapper;
using ShoppingCartDataAccess.DBEntities;
using ShoppingCartMonolithApplication.DTO;

namespace ShoppingCartMonolithApplication.Mappers
{
    public class ProductMappers : Profile
    {
        public ProductMappers()
        {
            //CreateMap<ProductAdd, Product>().ForMember(x => x.ProductCategory.CategoryId, x => x.MapFrom(src => src.ProductCategoryId));
            CreateMap<ProductAdd, Product>();//.ForMember(x => x.Pro, opt => opt.MapFrom(src => new Category {CategoryId = src.ProductCategoryId } ));
            //CreateMap<Product, ProductAdd>().ForMember(dest => dest.ProductCategory, opt => opt.MapFrom(src => src.ProductCategoryId));
        }
    }
}
