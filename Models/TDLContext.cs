using Microsoft.EntityFrameworkCore;

namespace ThisDevelopersLife.Models
{
    public class TDLContext : DbContext
    {      
        public DbSet<Episode> Episodes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase();
        }
    }
}