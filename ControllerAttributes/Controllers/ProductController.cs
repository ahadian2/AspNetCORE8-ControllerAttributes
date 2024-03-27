using Microsoft.AspNetCore.Mvc;

namespace ControllerAttributes.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
