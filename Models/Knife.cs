using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson1.Models
{
    public class Knife
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }

        [Display(Name = "Typ ostrza")]
        public string Type { get; set; }

        [Display(Name = "Materiał rękojeści")]
        public string Material { get; set; }

        [Display(Name = "Stopień ostrości")]
        public int Sharpness { get; set; }

        [Display(Name = "Długość ostrza")]
        public int Length { get; set; }

        [Display(Name = "Waga")]
        public int Weight { get; set; }
    }
}
