using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApplication.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category {CategoryId=1,CategoryName="Soup",Description="Soup"},
                    new Category {CategoryId=2,CategoryName="South Indian",Description="South Indian"},
                    new Category {CategoryId=3,CategoryName="North Indian",Description="North Indian"},
                    new Category {CategoryId=4,CategoryName="Chinese",Description="Noodles"},
                    new Category {CategoryId=5,CategoryName="Snakes",Description="Snakes"}
                };
            }
        }
    }
}
