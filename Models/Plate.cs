using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson1.Models
{
    public class Plate
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }

        [Display(Name = "Średnica")]
        public int Diameter { get; set; }

        [Display(Name = "Waga")]
        public int Weight { get; set; }

        [Display(Name = "Kolor")]
        public string Color { get; set; }

        [Display(Name = "Materiał wykonania")]
        public string Material { get; set; }

        [Display(Name = "Wysokość")]
        public int Height { get; set; }
    }
}
