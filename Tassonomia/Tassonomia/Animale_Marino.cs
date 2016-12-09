﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Animale_Marino: Animale_Acquatico
    {
        public Animale_Marino(string nome, string tipo, string movimento) : base(nome, tipo, "Mare", 0, movimento)
        {}
    }
}
