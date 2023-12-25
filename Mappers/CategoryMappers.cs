using AutoMapper;
using ShoppingCartDataAccess.DBEntities;
using ShoppingCartMonolithApplication.DTO;

namespace ShoppingCartMonolithApplication.Mappers
{
    public class CategoryMappers:Profile
    {
        public CategoryMappers()
        {
            CreateMap<CategoryAdd, Category>();
        }
    }
}
