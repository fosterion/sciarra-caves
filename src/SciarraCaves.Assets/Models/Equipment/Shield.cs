using SciarraCaves.Assets.Enums;
using SciarraCaves.Assets.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Assets.Models.Equipment
{
    public class Shield : HandCarriedItem
    {
        public double ProtectionPercent { get; set; }

        public Shield(double protectionPercent, int needStrength, Size size, Name name, Rarity rarity)
            : base(needStrength, size, name, rarity)
        {
            ProtectionPercent = protectionPercent;
        }
    }
}
