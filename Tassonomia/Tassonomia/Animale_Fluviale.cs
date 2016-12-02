using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Animale_Fluviale : Animale_Acquatico
    {
        public Animale_Fluviale(string nome, string tipo, string habitat, int zampe, string movimento) : base(nome, tipo, habitat, zampe, movimento)
        {}
    }
}
