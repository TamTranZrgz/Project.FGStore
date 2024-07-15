using Microsoft.AspNetCore.Mvc;

namespace Project.FGStore.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
