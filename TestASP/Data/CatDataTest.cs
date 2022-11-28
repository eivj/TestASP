using System;
using System.Collections.Generic;

using System.Threading.Tasks;
using TestASP.Context;
using TestASP.Interfaces;
using TestASP.Models;

namespace TestASP.Data
{
    //public class CatDataTest : ICatData
    //{
    //    static List<Cat> data;

    //    public CatDataTest()
    //    {
    //        data = new List<Cat>()
    //        {
    //            new Cat(){Id = 1, Breed = "Chartreux Cat Breed", Color = "Grey", DateOfBirthday = new DateTime(2020,10,20), Price = 150 },
    //            new Cat(){Id = 2, Breed = "Exotic Shorthair Cat Breed", Color = "White", DateOfBirthday = new DateTime(2021,12,15), Price = 250 }
    //        };
    //    }
    //    public void AddCat(Cat cat)
    //    {
    //        data.Add(cat);
    //    }

    //    public decimal BuyTheCat(int Id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public async Task EditCat(int id, string breed, DateTime dateOfBirthday, decimal price, string color)
    //    {
    //        Cat cat = data.Find(x => x.Id == id);
    //        int CurrentIndexCat = data.IndexOf(cat);
    //        Cat ModifiedCat = new Cat()
    //        {
    //            Id = id,
    //            Breed = breed,
    //            DateOfBirthday = dateOfBirthday,
    //            Price = price,
    //            Color = color
    //        };
    //        data[CurrentIndexCat] = ModifiedCat;
          
    //    }
    //    public IEnumerable<Cat> GetCat()
    //    {
    //        return data;
    //    }

    //    public void RemoveTheCat(int Id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public async Task<Cat> ShowCatForEdit(int id)
    //    {
    //        Cat currentCat = new Cat();
    //        currentCat = data.Find(x => x.Id == id);
    //        return currentCat;
    //    }
    //}
}
