using AdvancedProgramming_Lesson1.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedProgramming_Lesson1.Data
{
    public class MvcAuthorContext : DbContext
    {
        public MvcAuthorContext(DbContextOptions<MvcAuthorContext> options)
        : base(options)
        {
        }
        public DbSet<Author> Author { get; set; }
    }
}

