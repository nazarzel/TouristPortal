using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TouristPortal.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string MapX { get; set; }
        public string MapY { get; set; }
        public string LogoUrl { get; set; }
        public bool IsProductOfMonth { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public string Country { get; set; }
        public string Time { get; set; }
        public Category Category { get; set; }
        public string Notes { get; set; }
    }
}
