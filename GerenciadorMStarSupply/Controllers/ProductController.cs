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
    }
}
