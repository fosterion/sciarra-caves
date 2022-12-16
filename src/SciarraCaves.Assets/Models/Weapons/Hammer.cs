using SciarraCaves.Assets.Models.Weapons.Base;
using SciarraCaves.Assets.Models.Weapons.DamageType;
using SciarraCaves.Assets.Models.Weapons.GripType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Assets.Models.Weapons
{
    public class Hammer : Weapon, ITwoHanded, ICrushingDamage
    {
    }
}
