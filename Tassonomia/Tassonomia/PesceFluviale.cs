using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class PesceFluviale : Animale_Fluviale
    {
        public PesceFluviale(string nome): base(nome, "Pesce", "splash splash")
        {}
    }
}
