using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Assets.Models
{
    public class Name
    {
        public string? Adjective { get; private set; }

        public string Title { get; private set; }

        public Name(string adjective, string title)
        {
            Adjective = adjective;
            Title = title;
        }

        public Name(string title)
        {
            Title = title;
        }
    }
}
