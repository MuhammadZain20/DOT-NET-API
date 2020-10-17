
using Microsoft.EntityFrameworkCore;

namespace StudentApi.Models
{
    public class studentContext : DbContext
    {
        public studentContext(DbContextOptions<studentContext> options)
            : base(options)
        {
        }

        public DbSet<Student> TodoItems { get; set; }
    }
}