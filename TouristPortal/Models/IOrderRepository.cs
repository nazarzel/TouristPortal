using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TouristPortal.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
        IEnumerable<Order> AllOrders { get; }
        Order GetOrderById(int orderId);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);
    }
}
