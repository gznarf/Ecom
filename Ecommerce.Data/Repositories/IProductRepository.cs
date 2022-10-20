using Ecommerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data.Repositories
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetById(int id);
        public void AddProduct(Product product);
        public Product EditProduct(Product updateproduct);
        public bool DeleteProduct(int id);
    }
}
