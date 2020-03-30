using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TouristPortal.Models;
using TouristPortal.ViewModels;

namespace TouristPortal.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly AppDbContext dbContext;
        private readonly ICategoryRepository categoryRepository;
        private readonly IOrderRepository orderRepository;
        public IOrderRepository OrderRepository { get; }

        public AdminController(IProductRepository productRepository, AppDbContext dbContext
            , ICategoryRepository categoryRepository, IOrderRepository orderRepository)
        {
            this.productRepository = productRepository;
            this.dbContext = dbContext;
            this.categoryRepository = categoryRepository;
            this.orderRepository = orderRepository;
        }
        private dynamic ConvertToExpandoObject<T>(T value)
        {
            var result = new ExpandoObject();
            var valueType = typeof(T);
            foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(valueType))
            {
                ((IDictionary<String, Object>)result)[property.Name] = property.GetValue(value);
            }
            return result as ExpandoObject;
        }
        public ViewResult Index()
        {
            var products = productRepository.AllProducts.OrderBy(p => p.ProductId);
            var orders = orderRepository.AllOrders.OrderBy(o => o.OrderId);
            var orderDetails = dbContext.OrderDetails;
            var model = new AdminViewModel()
            {
               Products = products,
                Orders = orders,
                OrderDetails = orderDetails
                
            };
            return View(model);
        }

        public IActionResult AddProduct()
        {
            var categories = categoryRepository.AllCategories;
            var productEditViewModel = new ProductEditViewModel()
            {
                Categories = categories.Select(c => new SelectListItem() { Text = c.CategoryName, Value = c.CategoryId.ToString() }).ToList(),
                CategoryId = categories.FirstOrDefault().CategoryId
            };
            return View(productEditViewModel);
        }

        [HttpPost]
        public IActionResult AddProduct(ProductEditViewModel productEditViewModel)
        {
            if (ModelState.IsValid)
            {
                productRepository.CreateProduct(productEditViewModel.product);
                return RedirectToAction("Index");
            }
            return View(productEditViewModel);
        }

        public IActionResult EditProduct(int productId)
        {
            var categories = categoryRepository.AllCategories;

            var product = productRepository.GetProductById(productId);

            var productEditViewModel = new ProductEditViewModel
            {
                Categories = categories.Select(c => new SelectListItem() { Text = c.CategoryName, Value = c.CategoryId.ToString() }).ToList(),
                product = product,
                CategoryId = product.CategoryId
            };

            var item = productEditViewModel.Categories.FirstOrDefault(c => c.Value == product.CategoryId.ToString());
            item.Selected = true;

            return View(productEditViewModel);
        }

        [HttpPost]
        public IActionResult EditProduct(ProductEditViewModel productEditViewModel)
        {

            if (ModelState.IsValid)
            {
                productRepository.UpdateProduct(productEditViewModel.product);
                return RedirectToAction("Index");
            }
            return View(productEditViewModel);
        }

        [HttpPost]
        public IActionResult DeleteProduct(int productId)
        {
            var product = productRepository.GetProductById(productId);
            productRepository.DeleteProduct(product);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Deleteorder(int orderId)
        {
            var order = orderRepository.GetOrderById(orderId);
            orderRepository.DeleteOrder(order);
            return RedirectToAction("Index");
        }
    }
}
