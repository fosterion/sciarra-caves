using SciarraCaves.Assets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Core.Managers
{
    public class BattleManager
    {
        public void Hit(Character character, Enemy enemy)
        {
            // Calculate damage
            // Cutting weapon + armor = -5% of damage
            // Crushing weapon + armor = +5% of damage

            var dmgManager = new DamageManager();
            var damage = dmgManager.CalculateDamageQuantity(character.Equipment.Weapon, enemy);

            // Hit
        }

        public void Hit(Enemy enemy, Character character)
        {

        }
    }
}
