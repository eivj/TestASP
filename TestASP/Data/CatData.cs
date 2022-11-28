using System;
using System.Collections.Generic;

using System.Threading.Tasks;
using TestASP.Context;
using TestASP.Interfaces;
using TestASP.Models;

namespace TestASP.Data
{
    public class CatData : ICatData
    {
        private readonly CatContext catContext;
        public decimal AllMoney;
        public CatData(CatContext catContext)
        {
            this.catContext = catContext;
        }
        public void AddCat(Cat cat)
        {
            catContext.cats.Add(cat);
            catContext.SaveChanges();
        }
        public async Task EditCat(int id, string breed, DateTime dateOfBirthday, decimal price, string color)
        {
            Cat catForEdit = new Cat();
            using (catContext)
            {
                catForEdit = await catContext.cats.FindAsync(id);
                catForEdit.Breed = breed;
                catForEdit.DateOfBirthday = dateOfBirthday;
                catForEdit.Price = price;
                catForEdit.Color = color;
                catContext.SaveChanges();
            }
            //return catForEdit;
        }


        public async Task<Cat> ShowCatForEdit(int id)
        {
            Cat currentCat = new Cat();
            currentCat = await catContext.cats.FindAsync(id);
            return currentCat;
        }

        public void RemoveTheCat(int id)
        {
            Cat CatForDelete = catContext.cats.Find(id);
            catContext.cats.Remove(CatForDelete);
            catContext.SaveChanges();
        }
        public decimal BuyTheCat(int id)
        {
            Cat CatForDelete = catContext.cats.Find(id);
            decimal money = CatForDelete.Price;
            catContext.cats.Remove(CatForDelete);
            catContext.SaveChanges();    
            return money;
        }
        public IEnumerable<Cat> GetCat()
        {
            return this.catContext.cats;
        }
    }
}
