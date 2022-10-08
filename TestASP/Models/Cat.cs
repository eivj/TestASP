using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace TestASP.Models
{
    public class Cat
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Breed { get; set; }

        [Display(Name = "Date of birthday")]
        [StringLength(160)]
        public DateTime DateOfBirthday { get; set; }
        [StringLength(160)]
        public decimal Price { get; set; }
        [StringLength(160)]
        public string Color { get; set; }
    }
}
