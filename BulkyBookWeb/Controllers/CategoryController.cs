using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            this._db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objCategroryList = _db.Categories;
            return View(objCategroryList);
        }

        // GET
        public IActionResult Create()
        {
            
            return View();
        }


        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Category _category)
        {
            _db.Categories.Add(_category);
            _db.SaveChanges();
            return RedirectToAction("Index");
           
        }
    }
}
