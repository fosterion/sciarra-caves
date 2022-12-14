using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    internal class ChanceAttribute : Attribute
    {
        internal double Value { get; set; }

        public ChanceAttribute(double value)
        {
            Value = value;
        }
    }
}
