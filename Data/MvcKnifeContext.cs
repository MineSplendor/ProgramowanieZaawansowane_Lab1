using AdvancedProgramming_Lesson1.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedProgramming_Lesson1.Data
{
    public class MvcKnifeContext : DbContext
    {
        public MvcKnifeContext(DbContextOptions<MvcKnifeContext> options)
        : base(options)
        {
        }
        public DbSet<Knife> Knife { get; set; }
    }
}

