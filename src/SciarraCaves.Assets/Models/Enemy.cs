using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Assets.Models
{
    public class Enemy
    {
        public string Name { get; set; }

        public int Level { get; set; }

        public double Health { get; set; }

        public double Armor { get; set; }

        public Damage Damage { get; set; }

        public Enemy(string name, int level, double health, double armor, Damage damage)
        {
            Name = name;
            Level = level;
            Health = health;
            Armor = armor;
            Damage = damage;
        }
    }
}
