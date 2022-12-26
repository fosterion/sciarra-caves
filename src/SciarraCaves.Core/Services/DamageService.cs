using SciarraCaves.Assets.Enums;
using SciarraCaves.Assets.Models.Character;
using SciarraCaves.Assets.Models.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Core.Services
{
    public interface IDamageService
    {
        public void SayHello();
    }

    public class DamageService : IDamageService
    {
        private readonly string test = "TestString";

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

        public void SayHello()
        {
            Console.WriteLine($"Hi, it's a {test}");
        }
    }
}
