using AdvancedProgramming_Lesson1.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedProgramming_Lesson1.Data
{
    public class MvcDrinkContext : DbContext
    {
        public MvcDrinkContext(DbContextOptions<MvcDrinkContext> options)
        : base(options)
        {
        }
        public DbSet<Drink> Drink { get; set; }
    }
}

