using SciarraCaves.Assets.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Assets.Enums
{
    internal enum Element
    {
        /// <summary>
        /// Default element known as None
        /// </summary>
        [Chance(45.00)] None,

        /// <summary>
        /// Good against ice element
        /// </summary>
        [Chance(15.00)] Fire,

        /// <summary>
        /// Good against fire element
        /// </summary>
        [Chance(15.00)] Ice,

        /// <summary>
        /// Good against armor
        /// </summary>
        [Chance(15.00)] Electricity,

        /// <summary>
        /// Imposes poison effect
        /// </summary>
        [Chance(15.00)] Acid
    }
}
