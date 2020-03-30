using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouristPortal.Models;

namespace TouristPortal.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> ProductsOfMonth { get; set; }
    }
}
