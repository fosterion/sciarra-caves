using SciarraCaves.Core.Managers;
using SciarraCaves.Managers;
using SciarraCaves.Storage;

namespace SciarraCaves
{
    class Program
    {
        static void Main(string[] args)
        {
            var hero = CharacterManager.CreateCharacter("hero",
                new Assets.Models.Character.Attributes(10, 10, 10));

            hero.Equipment.Weapon = new Assets.Models.Equipment.Weapon(
                new Assets.Models.Damage(10, 24),
                3,
                Assets.Enums.Size.Normal,
                new Assets.Models.Name("Pushka"),
                Assets.Enums.Rarity.Common);

            var enemy = CharacterManager.CreateEnemy("enemy",
                10, 100, 20, new Assets.Models.Damage(10, 20));

            var battleManager = new BattleManager();

            battleManager.Hit(hero, enemy);
            Console.WriteLine($"Enemy health after hit: {enemy.Health}");
        }

        private static void CheckDatabaseAvailability()
        {
            using var db = new GameContext();

            if (db.Accounts.Any())
            {
                Console.WriteLine(db.Accounts.First().Name);
                return;
            }

            db.Accounts.Add(new Storage.Models.Account()
            {
                Name = "Alesha",
                IsActive = true
            });

            db.SaveChanges();
        }
    }
}
