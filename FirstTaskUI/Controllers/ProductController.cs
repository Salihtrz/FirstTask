using Microsoft.AspNetCore.Mvc;

namespace FirstTaskUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateProduct()
        {
            return View();
        }
        public IActionResult UpdateProduct()
        {
            return View();
        }
    }
}
