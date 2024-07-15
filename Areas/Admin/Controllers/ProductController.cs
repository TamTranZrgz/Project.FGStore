using Microsoft.AspNetCore.Mvc;

namespace Project.FGStore.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
