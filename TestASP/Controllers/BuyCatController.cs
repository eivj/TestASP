using Microsoft.AspNetCore.Mvc;

namespace TestASP.Controllers
{
    public class BuyCatController : Controller
    {
        public IActionResult BuyCatPage()
        {
            return View();
        }
    }
}
