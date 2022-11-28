using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using TestASP.Context;
using TestASP.Interfaces;
using TestASP.Models;

namespace TestASP.Data
{
    public class CatBreedsData : ICatBreedsData
    {
        private readonly CatContext catContext;
        public CatBreedsData(CatContext catContext)
        {
            this.catContext = catContext;
        }
        public IEnumerable<CatBreeds> GetCat()
        {
            return this.catContext.catBreeds;
        }
    }
}
