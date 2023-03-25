using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson1.Models
{
    public class Phone
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }

        [Display(Name = "Pojemność pamięci")]
        public int Memory { get; set; }

        [Display(Name = "Liczba rdzeni procesora")]
        public int Cores { get; set; }

        [Display(Name = "Rozmiar ekranu")]
        public int ScreenSize { get; set; }

        [Display(Name = "Waga")]
        public int Weight { get; set; }        

        [Display(Name = "Pojemność baterii")]
        public int BatteryCapacity { get; set; }             
    }
}
