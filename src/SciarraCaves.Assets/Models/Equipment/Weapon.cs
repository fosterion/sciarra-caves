using SciarraCaves.Assets.Enums;
using SciarraCaves.Assets.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Assets.Models.Equipment
{
    public class Weapon : HandCarriedItem
    {
        public Damage Damage { get; set; }

        public DamageType DamageType { get; set; }

        public GripType GripType { get; set; }

        public Weapon(Damage damage, int needStrength, Size size, Name name, Rarity rarity)
            : base(needStrength, size, name, rarity)
        {
            Damage = damage;
        }
    }
}
