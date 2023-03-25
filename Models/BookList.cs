using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson1.Models
{
    public class BookList
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }

        [Display(Name = "Liczba stron")]
        public int Pages { get; set; }

        [Display(Name = "Rok wydania")]
        public int Release { get; set; }

        [Display(Name = "Nakład")]
        public int Circulation { get; set; }

        [Display(Name = "Ocena czytelników")]
        public int Rate { get; set; }        

        [Display(Name = "Cena")]
        public decimal Price { get; set; }             
    }
}
