using Microsoft.AspNetCore.Mvc;

namespace mvctraing.Controllers
{
    public class CategoryController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
