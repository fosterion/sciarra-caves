using SciarraCaves.Assets.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Assets.Models.Weapons.Base
{
    public abstract class WeaponBase
    {
        public Name Name { get; set; }

        public int NeedStrength { get; set; }

        public Size Size { get; set; }

        public Rarity Rarity { get; set; }
    }
}
