using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Pesce : Animale_Acquatico
    {
        public Pesce(string nome): base(nome, "Pesce", "Acqua", 0, "splash splash")
        {}
    }
}
