using Microsoft.EntityFrameworkCore;

namespace ThisDevelopersLife.Models
{
    public class TDLContext : DbContext
    {      
        public TDLContext(DbContextOptions options)
            : base(options)
        {

        }
        
        public DbSet<Episode> Episodes { get; set; }
    }
}