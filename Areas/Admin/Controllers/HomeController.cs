using Microsoft.AspNetCore.Mvc;

namespace Project.FGStore.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
