using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApplication.Models
{
    public class MockItemRepository : IItemRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Item> Items
        {
            get
            {
                return new List<Item>
                {
                    new Item {ItemId=1,ItemName="Tomato Soup",ShortDescription="Tomato Soup",LongDescription="Tomato Soup",ImageUrl="/Images/ts.jpg",CategoryId=1,Price=60.00M,Category=new MockCategoryRepository().Categories.First(x => x.CategoryId == 1)},
                    new Item {ItemId=2,ItemName="Paper Dosa",ShortDescription="Paper Dosa",LongDescription="Paper Dosa",ImageUrl="/Images/pd.jpg",CategoryId=2,Price=70.00M,Category=new MockCategoryRepository().Categories.First(x => x.CategoryId == 2) },
                    new Item {ItemId=3,ItemName="Matar Paneer",ShortDescription="Matar Paneer",LongDescription="Matar Paneer",ImageUrl="/Images/mp.jpg",CategoryId=3,Price=150.00M,Category=new MockCategoryRepository().Categories.First(x => x.CategoryId == 3) },
                    new Item {ItemId=4,ItemName="Hakka Noodles",ShortDescription="Hakka Noodles",LongDescription="Hakka Noodles",ImageUrl="/Images/hn.jpg",CategoryId=4,Price=200.00M,Category=new MockCategoryRepository().Categories.First(x => x.CategoryId == 4) },
                    new Item {ItemId=5,ItemName="Manchurian",ShortDescription="Manchurian",LongDescription="Manchurian",ImageUrl="/Images/m.jpg",CategoryId=4,Price=60.00M,Category=new MockCategoryRepository().Categories.First(x => x.CategoryId == 4) },
                    new Item {ItemId=6,ItemName="Chilli Potato",ShortDescription="Chilli Potato",LongDescription="Chilli Potato",ImageUrl="/Images/cp.jpg",CategoryId=5,Price=200.00M,Category=new MockCategoryRepository().Categories.First(x => x.CategoryId == 5) },
                    new Item {ItemId=7,ItemName="Chilli Paneer",ShortDescription="Chilli Paneer",LongDescription="Chilli Paneer",ImageUrl="/Images/pc.jpg",CategoryId=5,Price=60.00M,Category=new MockCategoryRepository().Categories.First(x => x.CategoryId == 5) }
                };
            }
        }

        public Item GetItemById(int itemId)
        {
            throw new NotImplementedException();
        }
    }
}
