using System.Collections.Generic;
using TechnicalInterview.Exercice3.DataLayer;
using TechnicalInterview.Exercice3.Models;

namespace TechnicalInterview.Exercice3.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product AddProduct(Product product)
        {
            return _productRepository.Add(product);
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.Get();
        }
    }
}