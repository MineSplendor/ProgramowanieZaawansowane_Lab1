using AdvancedProgramming_Lesson1.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedProgramming_Lesson1.Data
{
    public class MvcPlateContext : DbContext
    {
        public MvcPlateContext(DbContextOptions<MvcPlateContext> options)
        : base(options)
        {
        }
        public DbSet<Plate> Plate { get; set; }
    }
}

