using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson1.Models
{
    public class Drink
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }

        [Display(Name = "Typ")]
        public string Type { get; set; }

        [Display(Name = "Smak")]
        public string Flavor { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data przydatności")]
        public DateTime ExpirationDate { get; set; }

        [Display(Name = "Pojemność")]
        public int Capacity { get; set; }

        [Display(Name = "Cena")]
        public decimal Price { get; set; }
    }
}
