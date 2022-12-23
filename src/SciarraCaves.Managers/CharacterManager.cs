using SciarraCaves.Assets.Models.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Managers
{
    public class CharacterManager
    {
        public static Hero CreateCharacter(string name, Attributes attributes)
        {
            return new Hero(name, attributes);
        }
    }
}
