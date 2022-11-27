using Microsoft.EntityFrameworkCore;

namespace FilmApp.Entities
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<FilmFeatures> Features { get; set; }
        public DbSet<NextFilmFeatures> NextFilmFeatures { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Director> Directors { get; set; }

    }
}
