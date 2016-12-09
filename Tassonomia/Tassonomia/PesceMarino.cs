using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class PesceMarino : Animale_Marino
    {
        public PesceMarino(string nome) : base(nome, "Pesce", "splash splash")
        {}
    }
}
