using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson1.Models
{
    public class Shoe
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }

        [Display(Name = "Rodzaj materiału")]
        public string Material { get; set; }

        [Display(Name = "Rozmiar")]
        public int Size { get; set; }

        [Display(Name = "Waga")]
        public int Weight { get; set; }

        [Display(Name = "Długość wkładki")]
        public int Length { get; set; }

        [Display(Name = "Cena")]
        public decimal Price { get; set; }

        

        
    }
}
