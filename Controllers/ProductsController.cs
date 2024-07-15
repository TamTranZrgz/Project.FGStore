using Microsoft.AspNetCore.Mvc;

namespace Project.FGStore.Controllers
{
    [Route("/shop")]
    public class ProductsController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
