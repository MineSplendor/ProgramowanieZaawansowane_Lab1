using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson1.Models
{
    public class AuthorsBook
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }

        [Display(Name = "Tytuł")]
        public string Pages { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Rok wydania")]
        public DateTime ReleaseYear { get; set; }

        [Display(Name = "Gatunek literacki")]
        public string Genre { get; set; }

        [Display(Name = "Liczba stron")]
        public int Rate { get; set; }

        [Display(Name = "Cena")]
        public decimal Price { get; set; }
    }
}
