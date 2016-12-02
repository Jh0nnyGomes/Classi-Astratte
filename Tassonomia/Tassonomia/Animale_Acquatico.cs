using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Animale_Acquatico : Animale
    {
        public Animale_Acquatico(string nome, string tipo, string habitat, int zampe, string movimento) : base(nome, tipo, habitat, zampe, movimento)
        {}
    }
}
