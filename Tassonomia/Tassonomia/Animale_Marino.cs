using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Animale_Marino: Animale_Acquatico
    {
        public Animale_Marino(string nome, string tipo, string habitat, int zampe, string movimento) : base(nome, tipo, habitat, zampe, movimento)
        {}
    }
}
