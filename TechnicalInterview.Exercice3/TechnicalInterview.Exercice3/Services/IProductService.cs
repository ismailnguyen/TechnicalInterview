using System.Collections.Generic;
using TechnicalInterview.Exercice3.Models;

namespace TechnicalInterview.Exercice3.Services
{
    public interface IProductService
    {
        Product AddProduct(Product product);

        List<Product> GetAllProducts();
    }
}