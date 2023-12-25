using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartDataAccess.DBEntities;
using ShoppingCartDataAccess.Repositories;
using ShoppingCartMonolithApplication.DTO;
using ShoppingCartDataAccess.DataAccess;

namespace ShoppingCartMonolithApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategory _category;
        IMapper _mapper;
        public CategoryController(ICategory category, IMapper mapper)
        {
            _category = category;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Add(CategoryAdd category)
        {
            var newcategory = _mapper.Map<CategoryAdd, Category>(category);
            newcategory.Active = 1;
            newcategory.CreatedBy = 1001;
            _category.CreateCategory(newcategory);
            return Ok(category);
        }

    }
}
