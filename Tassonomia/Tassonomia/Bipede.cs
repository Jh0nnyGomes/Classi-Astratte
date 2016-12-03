using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Bipede : Animale_Terrestre
    {
        public Bipede(string nome, string tipo, string habitat, string movimento) : base(nome, tipo, habitat, 2, movimento)
        {}
    }
}
