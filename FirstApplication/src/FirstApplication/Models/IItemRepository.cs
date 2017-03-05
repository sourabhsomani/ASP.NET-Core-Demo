using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApplication.Models
{
    public interface IItemRepository
    {
        IEnumerable<Item> Items { get; }
        Item GetItemById(int itemId);
    }
}
