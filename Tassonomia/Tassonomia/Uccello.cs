using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Uccello : Bipede
    {
        public Uccello(string nome, string habitat, string movimento) : base(nome, "Uccello", habitat, movimento)
        {}
    }
}
