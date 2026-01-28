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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsync([Bind("Name,Description, Price")] Product product)
        {
            if (ModelState.IsValid)
            {
                var prodName= _context.Products.FirstOrDefault(p => p.Name == product.Name);
                if (prodName == null) {
                    product.CreatedDate = DateTime.Now;
                    _context.Products.Add(product);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", "Home");
                }
                
            }
            return View(product);
        }
    }
}
