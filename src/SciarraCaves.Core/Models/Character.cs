using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Core.Models
{
    public class Character
    {
        internal string Name { get; set; }

        internal int Health { get; set; }

        internal Attributes Attributes { get; set; }
    }
}
