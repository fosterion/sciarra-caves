using SciarraCaves.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves
{
    class Program
    {
        static void Main(string[] args)
        {
            using var db = new GameContext();

            if (db.Player.Any())
            {
                Console.WriteLine(db.Player.First().Name);
                return;
            }

            db.Player.Add(new Storage.Models.Player()
            {
                Name = "Alesha",
                IsActive = true
            });

            db.SaveChanges();
        }
    }
}
