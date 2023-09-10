using Microsoft.AspNetCore.Mvc;

namespace Unit1Project.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
