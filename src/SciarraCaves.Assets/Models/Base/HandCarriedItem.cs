using SciarraCaves.Assets.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Assets.Models.Base
{
    public abstract class HandCarriedItem : CarriedItem
    {
        public int NeedStrength { get; set; }

        public Size Size { get; set; }

        protected HandCarriedItem(int needStrength, Size size, Name name, Rarity rarity)
            : base(name, rarity)
        {
            NeedStrength = needStrength;
            Size = size;
        }
    }
}
