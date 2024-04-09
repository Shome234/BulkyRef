using BulkyRef.Data;
using Microsoft.AspNetCore.Mvc;

namespace BulkyRef.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _db;

        public CategoryController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var objList=_db.Categories.ToList();
            
            return View(objList);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
