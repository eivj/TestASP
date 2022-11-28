using System.Collections.Generic;
using TestASP.Models;

namespace TestASP.Interfaces
{
    public interface ICatBreedsData
    {
        IEnumerable<CatBreeds> GetCat();
    }
}
