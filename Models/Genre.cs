using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson1.Models
{
    public class Genre
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }

        [Display(Name = "Nazwa gatunku")]
        public string GenreName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data powstania")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Główne motywy")]
        public string MainThemes { get; set; }

        [Display(Name = "Popularność")]
        public int Popularity { get; set; }

        [Display(Name = "Liczba książek")]
        public int NoOfBooks { get; set; }
    }
}
