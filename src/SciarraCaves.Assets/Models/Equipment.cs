using SciarraCaves.Assets.Models.Weapons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Assets.Models
{
    public class Equipment
    {
        public Weapon Weapon { get; set; }

        public Shield Shield { get; set; }
    }
}
