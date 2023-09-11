using Microsoft.AspNetCore.Mvc;
using Unit1Project.Models;

namespace Unit1Project.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CalculateAge(Birthdate model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FV = model.CalculateAge();
            }
            else
            {
                ViewBag.FV = 0;
            }
            return View(model);
        }



    }
}
