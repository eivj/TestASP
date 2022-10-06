using Microsoft.AspNetCore.Mvc;

namespace TestASP.Controllers
{
    public class BreedController : Controller
    {
        public IActionResult BreedPage()
        {
            return View();
        }
    }
}
