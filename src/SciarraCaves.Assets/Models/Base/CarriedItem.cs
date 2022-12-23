using SciarraCaves.Assets.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Assets.Models.Base
{
    public abstract class CarriedItem
    {
        public Name Name { get; set; }

        public Rarity Rarity { get; set; }

        protected CarriedItem(Name name, Rarity rarity)
        {
            Name = name;
            Rarity = rarity;
        }
    }
}
