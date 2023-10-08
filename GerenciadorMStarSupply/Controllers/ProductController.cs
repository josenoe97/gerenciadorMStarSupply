using GerenciadorMStarSupply.Data;
using GerenciadorMStarSupply.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorMStarSupply.Controllers
{
    public class ProductController : Controller
    {
        readonly private GerenciadorContext _context;

        public ProductController(GerenciadorContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> products = _context.Products;
            return View(products);
        }

        public IActionResult Register() 
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int? id) 
        {
            if(id == null || id == 0)
                return NotFound();
            

            Product product = _context.Products.FirstOrDefault(p => p.Id == id);

            if(product == null)
                return NotFound();

            return View(product);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
                return NotFound();


            Product product = _context.Products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return NotFound();

            return View(product);
        }

        [HttpPost]
        public IActionResult Register(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Update(product);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            if(product == null)
                return NotFound();

            _context.Products.Remove(product);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
