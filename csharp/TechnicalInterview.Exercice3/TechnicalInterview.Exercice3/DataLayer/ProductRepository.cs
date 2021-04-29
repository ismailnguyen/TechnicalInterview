using System;
using System.Collections.Generic;
using System.Linq;
using TechnicalInterview.Exercice3.Models;

namespace TechnicalInterview.Exercice3.DataLayer
{
    public class ProductRepository : IProductRepository
    {
        private  List<Product> products;

        public ProductRepository()
        {
            products = new List<Product>();
        }

        public Product Add(Product product)
        {
            if (products.Any(p => p.Name.Equals(product.Name)))
                throw new Exception("Product is already added !");

            var lastProductId = products.Any() ? products.Last().Id : 0;

            product.Id = lastProductId + 1;

            products.Add(product);

            return product;
        }

        public List<Product> Get()
        {
            return products;
        }
    }
}