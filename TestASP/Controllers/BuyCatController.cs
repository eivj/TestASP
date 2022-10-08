using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TestASP.Context;
using TestASP.Models;

namespace TestASP.Controllers
{
    public class BuyCatController : Controller
    {
      
        public IActionResult BuyCatPage()
        {
            List<Cat> cat = new List<Cat>();
          
           
            using (var context = new CatContext())
            {
                foreach (var item in context.cats)
                {
                    cat.Add(item);
                }
                ViewGenerationCat.Cats = cat;

            }
            return View();
        }
        public IActionResult AddCat()
        {
           
            return View();
        }

        /// <summary>
        /// Adding data to the database
        /// </summary>
        /// <param name="breed"></param>
        /// <param name="dateOfBirthday"></param>
        /// <param name="price"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddDataToContext(string breed, DateTime dateOfBirthday, decimal price, string color)
        {
            using (var context = new CatContext())
            {
                context.cats.Add(
                    new Cat()
                    {
                        Breed = breed,
                        DateOfBirthday = dateOfBirthday,
                        Price = price,
                        Color = color

                    });
                context.SaveChanges();
            }
            //HomePgae
            return Redirect("~/");
        }
    }
}
