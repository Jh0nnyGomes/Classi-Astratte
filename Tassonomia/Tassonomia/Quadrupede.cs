﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Quadrupede : Animale_Terrestre
    {
        public Quadrupede(string nome, string habitat, string movimento) : base(nome, "Quadrupede", habitat, 4, movimento)
        {}
    }
}
