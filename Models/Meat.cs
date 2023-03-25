using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson1.Models
{
    public class Meat
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }

        [Display(Name = "Rodzaj")]
        public string Type { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data przydatności")]
        public DateTime ExpirationDate { get; set; }

        [Display(Name = "Waga")]
        public int Weight { get; set; }

        [Display(Name = "Procentowa zawartość tłuszczu")]
        public int Fat { get; set; }           

        [Display(Name = "Cena")]
        public decimal Price { get; set; }             
    }
}
