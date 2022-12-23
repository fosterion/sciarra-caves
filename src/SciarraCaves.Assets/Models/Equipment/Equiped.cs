using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Assets.Models.Equipment
{
    public class Equiped
    {
        public Weapon? Weapon { get; set; }

        public Shield? Shield { get; set; }

        public Armor? Armor { get; set; }

        public Amulet? Amulet { get; set; }
    }
}
