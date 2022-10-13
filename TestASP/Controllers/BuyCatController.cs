using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using TestASP.Context;
using TestASP.Models;

namespace TestASP.Controllers
{
    public class BuyCatController : Controller
    {
      
        public IActionResult BuyCatPage()
        {
            List<Cat> cat = new List<Cat>();

            //Reading data from database
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
        /// Delete the purchased cat from the database
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public IActionResult Buy(int Id)
        {
            using (var context = new CatContext())
            {
                Cat cat_Remove = context.cats.Find(Id);
                context.cats.Remove(cat_Remove);
                context.SaveChanges();
            }
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

        [HttpGet]
        public async Task<IActionResult> Edit(int Id)
        {
            Cat Curent_Cat;
            using(var context = new CatContext())
            {
                Curent_Cat = await context.cats.FindAsync(Id);
            }
            
            return View(Curent_Cat);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int Id, string breed, DateTime dateOfBirthday, decimal price, string color)
        {
            Cat Curent_Cat;
            using (var context = new CatContext())
            {
                Curent_Cat = await context.cats.FindAsync(Id);
                Curent_Cat.Breed = breed;
                Curent_Cat.DateOfBirthday = dateOfBirthday;
                Curent_Cat.Price = price;
                Curent_Cat.Color = color;
                context.SaveChanges();
            }

            return Redirect("~/");
        }
    }
}
