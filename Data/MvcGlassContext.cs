using AdvancedProgramming_Lesson1.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedProgramming_Lesson1.Data
{
    public class MvcGlassContext : DbContext
    {
        public MvcGlassContext(DbContextOptions<MvcGlassContext> options)
        : base(options)
        {
        }
        public DbSet<Glass> Glass { get; set; }
    }
}

