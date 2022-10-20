using Ecommerce.Data.Models;
using Ecommerce.Domain.DTO;
using Ecommerce.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetAllProducts()
        {
            var product = _productService.GetAllProducts();
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTO>>GetProduct(int id)
        {
            var product =  _productService.GetAllProducts();
            if(product == null)
            {
                return NotFound();
            }

            var prod = _productService.GetById(id);

            if(prod == null)
            {
                return NotFound();
            }
            return Ok(prod);
        }

        [HttpGet("categorieid/{categorieId:int}")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProductsByCategorieId(int categoriId)
        {
            var products = _productService.GetByCategorieId(categoriId);
            if(products == null)
            {
                return NotFound();
            }
            return products;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult>PutProduct(int id, ProductDTO product)
        {
            try
            {
                _productService.EditProduct(id, product);
            }
            catch(DbUpdateConcurrencyException ex)
            {
                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Product>>PostProduct(ProductDTO product)
        {
            var products = _productService.GetAllProducts();
            if(products == null)
            {
                return Problem("Entity set 'EcomDbContext.Products' is null ");
            }
            try
            {
                _productService.AddProduct(product);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult>Delete(int Id)
        {
            var product = _productService.GetAllProducts();
            if(product == null)
            {
                return NotFound();
            }

            try
            {
                var deleteFlag = _productService.DeleteProduct(Id);
                if (!deleteFlag)
                {
                    return NotFound();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return NoContent();
        }
    }
}
