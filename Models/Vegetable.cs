using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson1.Models
{
    public class Vegetable
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

        [Display(Name = "Ilość cukru")]
        public int Sugar { get; set; }

        [Display(Name = "Cena")]
        public decimal Price { get; set; }
    }
}
