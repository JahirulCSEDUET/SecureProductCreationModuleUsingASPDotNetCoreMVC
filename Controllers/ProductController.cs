using Microsoft.AspNetCore.Mvc;
using SecureProductCreationModuleUsingASPDotNetCoreMVC.Data;
using SecureProductCreationModuleUsingASPDotNetCoreMVC.Domain.Entities;

namespace SecureProductCreationModuleUsingASPDotNetCoreMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly SequreProductDbContext _context;
        public ProductController( SequreProductDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create( Product product)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Home/index");
            }
            return View();
        }
    }
}
