using Microsoft.AspNetCore.Mvc;

namespace TestASP.Controllers
{
    public class InterestingFactsController : Controller
    {
        public IActionResult InterestingFactsPage()
        {
            return View();
        }
    }
}
