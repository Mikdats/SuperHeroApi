using Microsoft.EntityFrameworkCore;

namespace SuperHero.DataAccess
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<SuperHeroModel> SuperHeroes { get; set; }
        
    }
}
