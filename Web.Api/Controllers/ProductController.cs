using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository repo)
        {
            _productRepository = repo;
        }

        [HttpGet("getproducts")]
        public async Task<ActionResult<List<Products>>> GetProducts()
        {
            var products = await _productRepository.GetProductsAsync();
            return Ok(products);
        }

        [HttpGet("getproduct/{id}")]
        public async Task<ActionResult<Products>> GetProduct(int id)
        {
            return await _productRepository.GetProductByIdAsync(id);

        }

        [HttpGet("getproductbrands")]
        public async Task<ActionResult<List<Products>>> GetProductBrands()
        {
            var productBrands = await _productRepository.GetProductBrandsAsync();
            return Ok(productBrands);
        }

        [HttpGet("getproducttypes")]
        public async Task<ActionResult<List<Products>>> GetProductTypes()
        {
            var productTypes = await _productRepository.GetProductTypessAsync();
            return Ok(productTypes);
        }
    }
}
