using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartDataAccess.DBEntities;
using ShoppingCartDataAccess.Repositories;
using ShoppingCartMonolithApplication.DTO;

namespace ShoppingCartMonolithApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProducts _products;
        IMapper _mapper;
        public ProductsController(IProducts products,IMapper mapper)
        {
            _products = products;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Add(ProductAdd product)
        {
            var newproduct = _mapper.Map<ProductAdd, Product>(product);
            newproduct.Active = 1;
            newproduct.CreatedBy = 1001;
            newproduct.ProductDiscountPrice = (newproduct.ProductPrice / 100) * newproduct.ProductDiscount;
            _products.CreateProduct(newproduct);
            return Ok(product);
        }
    }
}
