using SciarraCaves.Assets.Models.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Assets.Models.Character
{
    public class Hero
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public Attributes Attributes { get; set; }

        public Equiped Equipment { get; set; }

        public Hero(string name, Attributes attributes)
        {
            Name = name;
            Health = 100;
            Attributes = attributes;
            Equipment = new Equiped();
        }
    }
}
