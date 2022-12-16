using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Assets.Models
{
    public class Character
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public Attributes Attributes { get; set; }

        public Equipment Equipment { get; set; }
    }
}
