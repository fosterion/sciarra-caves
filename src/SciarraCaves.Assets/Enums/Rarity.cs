using SciarraCaves.Assets.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Assets.Enums
{
    public enum Rarity
    {
        [Chance(45.00)] Common,
        [Chance(27.00)] Uncommon,
        [Chance(14.00)] Rare,
        [Chance(09.00)] Epic,
        [Chance(05.00)] Legendary
    }
}
