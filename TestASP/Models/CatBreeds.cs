using System.ComponentModel.DataAnnotations;

namespace TestASP.Models
{
    public class CatBreeds
    {
        [Key]
        public int Id { get; set; }
        public string PictureURL { get; set; }
        public string Breed { get; set; }
        public string Description { get; set; }
    }
}
