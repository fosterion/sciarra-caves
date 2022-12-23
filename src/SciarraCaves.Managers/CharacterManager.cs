using SciarraCaves.Assets.Models;
using SciarraCaves.Assets.Models.Character;
using SciarraCaves.Assets.Models.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Managers
{
    public class CharacterManager
    {
        public static Hero CreateCharacter(string name, Attributes attributes)
        {
            return new Hero(name, attributes);
        }

        public static Enemy CreateEnemy(string name, int level, double health, double armor, Damage damage)
        {
            return new Enemy(name, level, health, armor, damage);
        }
    }
}
