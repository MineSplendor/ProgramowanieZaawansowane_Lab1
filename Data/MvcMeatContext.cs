using AdvancedProgramming_Lesson1.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedProgramming_Lesson1.Data
{
    public class MvcMeatContext : DbContext
    {
        public MvcMeatContext(DbContextOptions<MvcMeatContext> options)
        : base(options)
        {
        }
        public DbSet<Meat> Meat { get; set; }
    }
}

