using Core.Data;
using Infrastructure.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly StoreContext _context;
        public ProductController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet("getproducts")]
        public ActionResult<List<Products>> GetProducts()
        {
           var products = _context.Products.ToList();
            return Ok(products);
        }

        [HttpGet("getproduct")]
        public string GetProduct()
        {
            return "This is my second controller. :-)";

        }
    }
}
