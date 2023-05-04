using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace ManageHero.Context
{
    public class HeroContext : DbContext
    {
        public HeroContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MSI;Trusted_Connection=True;Initial Catalog=ManageHero;Database=Hero;User ID=sa;Password=1234;Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Power> Powers { get; set; }
    }

}
