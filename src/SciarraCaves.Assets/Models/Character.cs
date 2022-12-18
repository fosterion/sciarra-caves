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

        public CharacterAttributes Attributes { get; set; }

        public Equipment Equipment { get; set; }

        public Character(string name, CharacterAttributes attributes)
        {
            Name = name;
            Health = 100;
            Attributes = attributes;
            Equipment = new Equipment();
        }
    }
}
