using Microsoft.EntityFrameworkCore;
using SciarraCaves.Storage.Models;

namespace SciarraCaves.Storage
{
    public class GameContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Character> Characters { get; set; }

        public GameContext()
        {
#if DEBUG
            Database.EnsureDeleted();
#endif
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);

            options.UseSqlite($"Data Source={Path.Join(path, "game.db")}");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            CreateIndexes(builder);
        }

        private static void CreateIndexes(ModelBuilder builder)
        {
            builder.Entity<Account>().HasIndex(i => i.Uid).IsUnique(true);
            builder.Entity<Character>().HasIndex(i => i.Uid).IsUnique(true);
        }
    }
}