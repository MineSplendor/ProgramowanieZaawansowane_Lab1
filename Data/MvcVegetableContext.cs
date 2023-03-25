using AdvancedProgramming_Lesson1.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedProgramming_Lesson1.Data
{
    public class MvcVegetableContext : DbContext
    {
        public MvcVegetableContext(DbContextOptions<MvcVegetableContext> options)
        : base(options)
        {
        }
        public DbSet<Vegetable> Vegetable { get; set; }
    }
}

