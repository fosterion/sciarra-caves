using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Assets.Models.Weapons.Base
{
    public abstract class Weapon : WeaponBase
    {
        public Damage Damage { get; set; }
    }
}
