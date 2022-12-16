using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Assets.Models
{
    public class Enemy
    {
        public string Name { get; set; }

        public double Health { get; set; }

        public double Shield { get; set; }

        public Damage Damage { get; set; }
    }
}
