using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [HttpGet]
        [Authorize]
        public IActionResult AddCat()
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            catdata.RemoveTheCat(id);
            return Redirect("~/");
        }
        ///// <summary>
        ///// Delete the purchased cat from the database
        ///// </summary>
        ///// <param name="Id"></param>
        ///// <returns></returns>
        public  IActionResult Buy(int id)
        {      
            MoneyFromSales.AllMoney += catdata.BuyTheCat(id);
            return View(MoneyFromSales.AllMoney);
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
        public async Task<IActionResult> Edit(int Id, string breed, DateTime dateOfBirthday, decimal price, string color)
        {
            await catdata.EditCat(Id, breed, dateOfBirthday, price, color);
            return Redirect("~/");
        }
       
    }
}
