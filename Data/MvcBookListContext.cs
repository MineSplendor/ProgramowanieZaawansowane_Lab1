using AdvancedProgramming_Lesson1.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedProgramming_Lesson1.Data
{
    public class MvcBookListContext : DbContext
    {
        public MvcBookListContext(DbContextOptions<MvcBookListContext> options)
        : base(options)
        {
        }
        public DbSet<BookList> BookList { get; set; }
    }
}

