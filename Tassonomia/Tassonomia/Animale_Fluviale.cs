using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Animale_Fluviale : Animale_Acquatico
    {
        public Animale_Fluviale(string nome, string tipo, string movimento) : base(nome, tipo, "Fiume", 0, movimento)
        {}
    }
}
