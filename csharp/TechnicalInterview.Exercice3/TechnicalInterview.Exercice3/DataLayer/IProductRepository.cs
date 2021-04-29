using System.Collections.Generic;
using TechnicalInterview.Exercice3.Models;

namespace TechnicalInterview.Exercice3.DataLayer
{
    public interface IProductRepository
    {
        Product Add(Product product);

        List<Product> Get();
    }
}