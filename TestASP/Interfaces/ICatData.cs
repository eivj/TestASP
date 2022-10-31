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
        public void AddCat(Cat cat);
        public  Task EditCat(int id, string breed, DateTime dateOfBirthday, decimal price, string color);
        public Task<Cat> ShowCatForEdit(int id);
       
    }
}
