using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Core.Models
{
    internal class Weapon
    {
        internal string Name { get; set; }

        internal int Damage { get; set; }

        internal int NeedStrength { get; set; }

        internal Rarity Rarity { get; set; }
    }
}
