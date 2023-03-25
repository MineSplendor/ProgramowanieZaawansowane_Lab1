using AdvancedProgramming_Lesson1.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedProgramming_Lesson1.Data
{
    public class MvcGenreContext : DbContext
    {
        public MvcGenreContext(DbContextOptions<MvcGenreContext> options)
        : base(options)
        {
        }
        public DbSet<Genre> Genre { get; set; }
    }
}

