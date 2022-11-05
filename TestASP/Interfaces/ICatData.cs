using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestASP.Context;
using TestASP.Models;

namespace TestASP.Interfaces
{
    public interface ICatData
    {
        IEnumerable<Cat> GetCat();
        void AddCat(Cat cat);
        Task EditCat(int id, string breed, DateTime dateOfBirthday, decimal price, string color);
        void RemoveTheCat(int Id);
        decimal BuyTheCat(int Id);
        Task<Cat> ShowCatForEdit(int id);
       
    }
}
