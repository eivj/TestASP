using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TestASP.Context;
using TestASP.Interfaces;

namespace TestASP.Controllers
{
    public class BreedController : Controller
    {
        //private readonly ICatBreedsData catBreedsData;
        private readonly CatContext catContext;
        public BreedController(CatContext catContext)
        {
            this.catContext = catContext;
        }
        //public BreedController(ICatBreedsData catBreedsData)
        //{
        //    this.catBreedsData = catBreedsData;
        //}
        public IActionResult BreedPage()
        {
            return View(catContext.catBreeds.ToList());
        }
    }
}
