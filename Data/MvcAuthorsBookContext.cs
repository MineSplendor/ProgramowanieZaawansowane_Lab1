using AdvancedProgramming_Lesson1.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedProgramming_Lesson1.Data
{
    public class MvcAuthorsBookContext : DbContext
    {
        public MvcAuthorsBookContext(DbContextOptions<MvcAuthorsBookContext> options)
        : base(options)
        {
        }
        public DbSet<AuthorsBook> AuthorsBook { get; set; }
    }
}
