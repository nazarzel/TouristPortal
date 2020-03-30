using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TouristPortal.Models
{
    public interface IProductRepository
    {

        IEnumerable<Product> AllProducts { get; }
        IEnumerable<Product> ProductsOfMonth { get; }
        Product GetProductById(int productId);
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
       
    }
}
