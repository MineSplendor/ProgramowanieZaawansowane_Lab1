using AdvancedProgramming_Lesson1.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedProgramming_Lesson1.Data
{
    public class MvcPhoneContext : DbContext
    {
        public MvcPhoneContext(DbContextOptions<MvcPhoneContext> options)
        : base(options)
        {
        }
        public DbSet<Phone> Phone { get; set; }
    }
}

