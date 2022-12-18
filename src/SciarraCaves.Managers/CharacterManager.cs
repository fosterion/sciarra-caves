using SciarraCaves.Assets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Managers
{
    public class CharacterManager
    {
        public static Character CreateCharacter(string name, CharacterAttributes attributes)
        {
            return new Character(name, attributes);
        }
    }
}
