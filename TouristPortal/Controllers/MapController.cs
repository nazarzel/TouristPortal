using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TouristPortal.Models;
using TouristPortal.ViewModels;

namespace TouristPortal.Controllers
{
    public class MapController : Controller
    {
        private readonly IProductRepository _productRepository;

        public MapController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            IEnumerable<Product> products;
            products = _productRepository.AllProducts.OrderBy(p => p.ProductId);
            return View(new ProductsListViewModel
            {
                Products = products
            });
        }
    }
}