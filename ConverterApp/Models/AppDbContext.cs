using Microsoft.EntityFrameworkCore;

namespace ConverterApp.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Units> Units { get; set; }
        public DbSet<Metrics> Metrics{ get; set; }
    }
}
