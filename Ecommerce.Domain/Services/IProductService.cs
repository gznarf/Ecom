using Ecommerce.Data.Models;
using Ecommerce.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Services
{
    public interface IProductService
    {
        public IEnumerable<ProductDTO> GetAllProducts();
        public ProductDTO GetById(int Id);
        public void AddProduct(ProductDTO Product);
        public List<Product> GetByCategorieId(int CategorieId);
        public Product EditProduct(int Id, ProductDTO UpdateProduct);
        public bool DeleteProduct(int Id);

    }
}
