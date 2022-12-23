using SciarraCaves.Assets.Enums;
using SciarraCaves.Assets.Models.Character;
using SciarraCaves.Assets.Models.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Core.Managers
{
    public class DamageManager
    {
        public double CalculateDamageQuantity(Weapon weapon, Enemy enemy)
        {
            var weaponDamage = weapon.Damage.InstantDamage();

            if (enemy.Armor > 0)
            {
                if (weapon.DamageType is DamageType.Cutting)
                {
                    weaponDamage -= weaponDamage * 0.05;
                }
                if (weapon.DamageType is DamageType.Crushing)
                {
                    weaponDamage += weaponDamage * 0.05;
                }
            }

            return weaponDamage;
        }

        public void TakeDamage(Hero character, Enemy enemy)
        {

        }
    }
}
