using SciarraCaves.Assets.Enums;
using SciarraCaves.Assets.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Assets.Models.Equipment
{
    public class Armor : CarriedItem
    {
        public Armor(Name name, Rarity rarity) : base(name, rarity)
        {
        }
    }
}
