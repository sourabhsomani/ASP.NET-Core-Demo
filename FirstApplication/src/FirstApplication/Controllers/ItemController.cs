using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstApplication.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstApplication.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemRepository _itemRepository;
        private readonly ICategoryRepository _categoryRepository;
        public ItemController(ICategoryRepository categoryRepository, IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
            _categoryRepository = categoryRepository;
        }
        public ActionResult List()
        {
            return View(_itemRepository.Items);
        }
    }
}
