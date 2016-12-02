using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Uomo : Bipede
    {
        public Uomo () : base("Uomo", "Bipede", "Terraferma", 2, " /_ \_ ")
        {}
    }
}
