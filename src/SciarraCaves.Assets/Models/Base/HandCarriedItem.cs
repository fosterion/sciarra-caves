using SciarraCaves.Assets.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Assets.Models.Base
{
    public class HandCarriedItem : CarriedItem
    {
        public int NeedStrength { get; set; }

        public Size Size { get; set; }
    }
}
