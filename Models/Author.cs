using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson1.Models
{
    public class Author
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }

        [Display(Name = "Imię")]
        public string FirstName { get; set; }

        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data urodzenia")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Kraj pochodzenia")]
        public string Country { get; set; }

        [Display(Name = "Liczba napisanych książek")]
        public int WrittenBooks { get; set; }
    }
}
