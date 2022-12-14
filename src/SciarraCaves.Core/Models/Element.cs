using SciarraCaves.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Core.Models
{
    internal enum Element
    {
        /// <summary>
        /// Default element known as None
        /// </summary>
        [Chance(50.00)] None,

        /// <summary>
        /// Good against ice element
        /// </summary>
        [Chance(25.00)] Fire,

        /// <summary>
        /// Good against the fire element
        /// </summary>
        [Chance(25.00)] Ice
    }
}
