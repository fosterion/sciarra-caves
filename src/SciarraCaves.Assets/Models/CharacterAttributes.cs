using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Assets.Models
{
    public class CharacterAttributes
    {
        public int Endurance { get; set; }

        public int Strength { get; set; }

        public int Agility { get; set; }

        public CharacterAttributes(int endurance, int strength, int agility)
        {
            Endurance = endurance;
            Strength = strength;
            Agility = agility;
        }
    }
}
