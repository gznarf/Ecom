using AutoMapper;
using Ecommerce.Data.Models;
using Ecommerce.Data.Repositories;
using Ecommerce.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public IEnumerable<ProductDTO> GetAllProducts()
        {
            var products = _productRepository.GetAllProducts();
            var productToReturn = _mapper.Map<IEnumerable<ProductDTO>>(products);
            return productToReturn;
        }

        public ProductDTO GetById(int Id)
        {
            var product = _productRepository.GetById(Id);
            var productToReturn = _mapper.Map<ProductDTO>(product);
            return productToReturn;
        }

        public List<Product>GetByCategorieId(int CategoriId)
        {
            return _productRepository.GetAllProducts().Where(p => p.ID_Categorie == CategoriId).ToList();
        }

        public void AddProduct(ProductDTO productDTO)
        {
            try
            {
                Product product = new Product()
                {
                    Cod_Product = productDTO.Cod_Product,
                    Name = productDTO.Name,
                    Description = productDTO.Description,
                    Mark = productDTO.Mark,
                    Price = productDTO.Price,
                    Stock = productDTO.stock,
                    ID_Categorie = productDTO.ID_Categorie
                };
                _productRepository.AddProduct(product);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Product EditProduct(int Id, ProductDTO UpdateProduct)
        {
            var oldProduct = _productRepository.GetById(Id);
            if(oldProduct != null)
            {
                oldProduct.Cod_Product = UpdateProduct.Cod_Product;
                oldProduct.Name = UpdateProduct.Name;
                oldProduct.Description = UpdateProduct.Description;
                oldProduct.Mark = UpdateProduct.Mark;
                oldProduct.Price = UpdateProduct.Price;
                oldProduct.Stock = UpdateProduct.stock;
                oldProduct.ID_Categorie = UpdateProduct.ID_Categorie;
                try
                {
                    return _productRepository.EditProduct(oldProduct);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return null;
        }

        public bool DeleteProduct(int Id)
        {
            if(Id < 0)
            {
                return false;
            }

            var product = _productRepository.GetById(Id);

            if(product == null)
            {
                throw new ApplicationException("Product Not Found");
            }
            try
            {
                return _productRepository.DeleteProduct(Id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
