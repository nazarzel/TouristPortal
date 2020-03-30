using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TouristPortal.Models
{
    public class ProductRepository: IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Product> AllProducts
        {
            get
            {
                return _appDbContext.Products.Include(c => c.Category);
            }
        }

        public IEnumerable<Product> ProductsOfMonth
        {
            get
            {
                return _appDbContext.Products.Include(c => c.Category).Where(p => p.IsProductOfMonth);
            }
        }

        public void CreateProduct(Product product)
        {
  
            _appDbContext.Products.Add(product);
            _appDbContext.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            _appDbContext.Products.Remove(product);
            _appDbContext.SaveChanges();
        }

        public Product GetProductById(int productId)
        {
            return _appDbContext.Products.FirstOrDefault(p => p.ProductId == productId);
        
        }

        public void UpdateProduct(Product product)
        {
            _appDbContext.Products.Update(product);
            _appDbContext.SaveChanges();
        }
        
    }
}
