using AdvancedProgramming_Lesson1.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedProgramming_Lesson1.Data
{
    public class MvcShoeContext : DbContext
    {
        public MvcShoeContext(DbContextOptions<MvcShoeContext> options)
        : base(options)
        {
        }
        public DbSet<Shoe> Shoe { get; set; }
    }
}

