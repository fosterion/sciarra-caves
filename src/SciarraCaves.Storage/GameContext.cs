using Microsoft.EntityFrameworkCore;
using SciarraCaves.Storage.Models;

namespace SciarraCaves.Storage
{
    public class GameContext : DbContext
    {
        public DbSet<Player> Player { get; set; }

        public GameContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            var _path = Path.Join(path, "game.db");

            options.UseSqlite($"Data Source={_path}");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            CreateIndexes(builder);
        }

        private static void CreateIndexes(ModelBuilder builder)
        {
            builder.Entity<Player>().HasIndex(i => i.Uid).IsUnique(true);
        }
    }
}