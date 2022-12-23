using SciarraCaves.Assets.Models.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Core.Managers
{
    public class BattleManager
    {
        public void Hit(Hero hero, Enemy enemy)
        {
            // Calculate damage
            // Cutting weapon + armor = -5% of damage
            // Crushing weapon + armor = +5% of damage

            var dmgManager = new DamageManager();
            var damage = dmgManager.CalculateDamageQuantity(hero.Equipment.Weapon, enemy);

            Console.WriteLine($"Damage: {damage}");

            // Hit
            enemy.Health -= damage;
        }

        public void Hit(Enemy enemy, Hero hero)
        {

        }
    }
}
