using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TouristPortal.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public IEnumerable<Order> AllOrders
        {
            get
            {
                return _appDbContext.Orders.OrderBy(o=>o.OrderId);
            }
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    ProductId = shoppingCartItem.Product.ProductId,
                    Price = shoppingCartItem.Product.Price
                };

                order.OrderDetails.Add(orderDetail);
            }

            _appDbContext.Orders.Add(order);

            _appDbContext.SaveChanges();
        }

        public void DeleteOrder(Order order)
        {
            _appDbContext.Orders.Remove(order);
            _appDbContext.SaveChanges();
        }

        public Order GetOrderById(int orderId)
        {
            return _appDbContext.Orders.FirstOrDefault(p => p.OrderId == orderId);
        }

        public void UpdateOrder(Order order)
        {
            
        }
    }
}
