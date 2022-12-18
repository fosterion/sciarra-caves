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
