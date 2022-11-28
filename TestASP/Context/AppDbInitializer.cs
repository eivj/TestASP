using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using TestASP.Models;

namespace TestASP.Context
{
    public class AppDbInitializer
    {
        public static void AddInitialData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<CatContext>();

                context.Database.EnsureCreated();
                if (!context.cats.Any())
                {
                    context.cats.AddRange(new List<Cat>()
                    {
                        new Cat()
                        {
                            Breed = "Abyssinian Cat",
                            Price = 200,
                            DateOfBirthday = DateTime.Now,
                            Color = "Grеy",
                        },
                        new Cat()
                        {
                            Breed = "Burmese Cat",
                            Price = 300,
                            DateOfBirthday = DateTime.Now,
                            Color = "Grеy",
                        },
                        new Cat()
                        {
                            Breed = "American Bobtail Cat Breed",
                            Price = 350,
                            DateOfBirthday = DateTime.Now,
                            Color = "Grеy",
                        },
                        new Cat()
                        {
                            Breed = "American Shorthair Cat",
                            Price = 300,
                            DateOfBirthday = DateTime.Now,
                            Color = "Grеy",
                        },
                        new Cat()
                        {
                            Breed = "American Wirehair Cat Bree",
                            Price = 400,
                            DateOfBirthday = DateTime.Now,
                            Color = "Grеy",
                        },
                        new Cat()
                        {
                            Breed = "Balinese-Javanese Cat Breed",
                            Price = 500,
                            DateOfBirthday = DateTime.Now,
                            Color = "Grеy",
                        },
                        new Cat()
                        {
                            Breed = "Japanese Bobtail Cat Breed",
                            Price = 1300,
                            DateOfBirthday = DateTime.Now,
                            Color = "White",
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.catBreeds.Any())
                {
                    context.catBreeds.AddRange(new List<CatBreeds>()
                    {
                        new CatBreeds()
                        {
                            Breed = "Abyssinian Cat",
                            Description = "Lithe and long, with a lean, muscular build and moderately wedge-shaped head and large, almond shaped eyes, the Abyssinian is a supermodel of a cat.",
                            PictureURL = "https://www.purina.co.uk/sites/default/files/styles/square_medium_440x440/public/2022-06/Abyssinian.1_0.jpg?h=da189af4&itok=u-RI49Pj"
                        },
                        new CatBreeds()
                        {
                            Breed = "Burmese Cat",
                            Description = "The head is round, the tips of the ears are round, the eyes, chin and even the feet are round.",
                            PictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5c/British_burmese_-_Andel_Alois_at_Cat_show.JPG/800px-British_burmese_-_Andel_Alois_at_Cat_show.JPG"
                        },
                        new CatBreeds()
                        {
                            Breed = "American Bobtail Cat Breed",
                            Description = "merican bobtails have large, deep-set eyes that are almond-shaped and can come in any color.",
                            PictureURL = "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F47%2F2022%2F04%2F01%2Forange-american-bobtail-kitten-808979798-2000.jpg"
                        },

                        new CatBreeds()
                        {
                             Breed = "American Shorthair Cat",
                             Description = "They have a large head and full face, medium-sized ears and large, wide eyes.",
                             PictureURL = "https://cf.ltkcdn.net/cats/cat-breeds/images/orig/323605-1600x1030-american-shorthair-cat-breed.jpg"
                        },

                        new CatBreeds()
                        {
                             Breed = "American Wirehair Cat Bree",
                             Description = "These cats are loving, easygoing, and affectionate companion animals.",
                             PictureURL = "https://s36537.pcdn.co/wp-content/uploads/2019/03/American-Wirehair-full-length.jpg.optimal.jpg"
                        },
                        new CatBreeds()
                        {
                            Breed = "Balinese-Javanese Cat Breed",
                            Description = "This long, slender cat is lithe but muscular, with a Siamese-style head, blue eyes and large, triangular ears.",
                            PictureURL = "https://d3544la1u8djza.cloudfront.net/APHI/Blog/2021/09-27/Javanese+cat+resting+atop+a+tan+sofa+by+a+green+wall.jpg"
                        },
                        new CatBreeds()
                        {
                             Breed = "Japanese Bobtail Cat Breed",
                             Description = "They have long, lean torsos and strong, muscular bodies.",
                             PictureURL = "https://a-z-animals.com/media/2021/11/japanese-bobtail-picture-id1217156553.jpg"
                        }
                      

                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
