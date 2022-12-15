﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Core.Models
{
    public class Damage
    {
        public int Least { get; private set; }

        public int Greatest { get; private set; }

        public Damage(int least, int greatest)
        {
            Least = least;
            Greatest = greatest;
        }
    }
}
