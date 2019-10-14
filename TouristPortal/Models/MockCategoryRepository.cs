using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TouristPortal.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Morze", Description="Realizujemy wycieczki nad morze, nie tylko latem, ale także w pozostałe pory roku." },
                new Category{CategoryId=2, CategoryName="Ocean", Description="4 oceany do twojej dyspozycji." },
                new Category{CategoryId=3, CategoryName="Góry", Description="Gimalai czy Alpy? A może od razu Everest? Potrafimy realizować wszystko" },
                new Category{CategoryId=4, CategoryName="Kultura", Description="Zobacz z nami 5 kontynentów świata" }
            };
    }
}
