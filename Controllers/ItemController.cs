using Microsoft.AspNetCore.Mvc;
using ShoppingList.Models;
using System.Linq;

namespace ShoppingList.Controllers
{
    public class ItemController : Controller
    {
        private readonly ItemDbContext _dbContext;
        public ItemController(ItemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

       

        [HttpGet]
        public IActionResult Index()
        {
            var items = _dbContext.Items.ToList();
            return View(items);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var item = _dbContext.Items.Find(id);
            return View(item);
        }

        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var item = _dbContext.Items.Find(id);
            return View(item);
        }

        public IActionResult Delete(int? id)
        {
            var item = _dbContext.Items.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        [HttpPost]
        public IActionResult Create(Item item)
        {
            var itemId = _dbContext.Items.Select(x => x.Id).Max() + 1;
            item.Id = itemId;
            _dbContext.Items.Add(item);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(Item item) 
        {
            _dbContext.Items.Update(item);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id) 
        {
            var item = _dbContext.Items.Find(id);
            _dbContext.Items.Remove(item);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
