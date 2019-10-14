using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouristPortal.Models;

namespace TouristPortal.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public string CurrentCategory { get; set; }
    }
}
