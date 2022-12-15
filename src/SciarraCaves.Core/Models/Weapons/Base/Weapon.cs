using SciarraCaves.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Core.Models.Weapons.Base
{
    public abstract class Weapon
    {
        public Name Name { get; set; }

        public Damage Damage { get; set; }

        public WeaponDamageType DamageType { get; set; }

        public int NeedStrength { get; set; }

        public Rarity Rarity { get; set; }

        //public abstract double GetDamageModificator();
    }
}
