using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouristPortal.Models;

namespace TouristPortal.ViewModels
{
    public class AdminViewModel
    {
        public IEnumerable<Models.Product> Products { get; set; }
        public IEnumerable<Models.Order> Orders { get; set; }
        public IEnumerable<Models.OrderDetail> OrderDetails { get; set; }
    }
}
