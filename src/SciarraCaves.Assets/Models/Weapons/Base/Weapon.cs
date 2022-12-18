using SciarraCaves.Assets.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Assets.Models.Weapons.Base
{
    public abstract class Weapon : HandCarriedItem
    {
        public Damage Damage { get; set; }
    }
}
