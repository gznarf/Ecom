using Ecommerce.Data.Data;
using Ecommerce.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly EcomDbContext _context;

        public ProductRepository(EcomDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products;
        }

        public Product GetById(int Id)
        {
            return _context.Products.Find(Id);
        }

        public void AddProduct(Product product)
        {
            if(product != null)
            {
                try
                {
                    _context.Products.Add(product);
                    _context.SaveChanges();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

        public Product EditProduct(Product UpdateProduct)
        {
            try
            {
                _context.Update(UpdateProduct);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return UpdateProduct;
        }

        public bool DeleteProduct(int Id)
        {
            var product = _context.Products.Find(Id);
            if(product != null)
            {
                try
                {
                    _context.Products.Remove(product);
                    _context.SaveChanges();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                return true;
            }
            return false;
        }
    }
}
