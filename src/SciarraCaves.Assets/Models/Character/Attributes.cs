using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Assets.Models.Character
{
    public class Attributes
    {
        public int Endurance { get; set; }

        public int Strength { get; set; }

        public int Agility { get; set; }

        public Attributes(int endurance, int strength, int agility)
        {
            Endurance = endurance;
            Strength = strength;
            Agility = agility;
        }
    }
}
