using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Animale
    {
        string nomeAnimale;
        string tipoAnimale;
        string habitat;
        int numeroZampe;
        string siMuove;


        public abstract void SiMuove();

        public Animale(string nome, string tipo, string luogo, int zampe, string movimento)
        {
            nomeAnimale = nome;
            tipoAnimale = tipo;
            habitat = luogo;
            numeroZampe = zampe;
            siMuove = movimento;
        }

        public void Riepilogo()
        {
            Console.WriteLine("Nome Animale: " + nomeAnimale);
            Console.WriteLine("Tipo Animale: " + tipoAnimale);
            Console.WriteLine("Habitat Animale: " + habitat);
            Console.WriteLine("Zampe Animale: " + numeroZampe.ToString());
            Console.WriteLine("Movimento Animale: " + siMuove);
        }
    }
}
