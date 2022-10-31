using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Metadata.Edm;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using TestASP.Context;
using TestASP.Data;
using TestASP.Interfaces;
using TestASP.Models;

namespace TestASP.Controllers
{
    public class BuyCatController : Controller
    {
        private readonly ICatData catdata;

        public BuyCatController(ICatData catdata)
        {
            this.catdata = catdata;
        }
        public IActionResult BuyCatPage()
        {    
            return View(catdata.GetCat());
        }

        public IActionResult AddCat()
        {
            return View();
        }

        ///// <summary>
        ///// Delete the purchased cat from the database
        ///// </summary>
        ///// <param name="Id"></param>
        ///// <returns></returns>
        //public IActionResult Buy(int Id)
        //{
        //    using (catContext)
        //    {
        //        Cat cat_Remove = catContext.cats.Find(Id);
        //        catContext.cats.Remove(cat_Remove);
        //        catContext.SaveChanges();
        //    }
        //    return View();
        //}

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
            var cat = new Cat()
            {
                Breed = breed,
                DateOfBirthday = dateOfBirthday,
                Price = price,
                Color = color

            };
            catdata.AddCat(cat);
            //HomePgae
            return Redirect("~/");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int Id)
        {
             Cat Curent_Cat = await catdata.ShowCatForEdit(Id);

            return View(Curent_Cat);
        }
        [HttpPost]
        public IActionResult Edit(int Id, string breed, DateTime dateOfBirthday, decimal price, string color)
        {
            catdata.EditCat(Id, breed, dateOfBirthday, price, color);
            return Redirect("~/");
        }
        //[HttpGet]
        //public async Task<IActionResult> Edit(int Id)
        //{
        //    Cat Curent_Cat;
        //    using (catContext)
        //    {
        //        Curent_Cat = await catContext.cats.FindAsync(Id);
        //    }

        //    return View(Curent_Cat);
        //}
        //[HttpPost]
        //public async Task<IActionResult> Edit(int Id, string breed, DateTime dateOfBirthday, decimal price, string color)
        //{
        //    Cat Curent_Cat;
        //    using (catContext)
        //    {
        //        Curent_Cat = await catContext.cats.FindAsync(Id);
        //        Curent_Cat.Breed = breed;
        //        Curent_Cat.DateOfBirthday = dateOfBirthday;
        //        Curent_Cat.Price = price;
        //        Curent_Cat.Color = color;
        //        catContext.SaveChanges();
        //    }

        //    return Redirect("~/");
        //}
    }
}
