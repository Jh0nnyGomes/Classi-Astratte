using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Program
    {
        static void Main(string[] args)
        {
            Uomo U = new Uomo();
            Cavallo Ca = new Cavallo();
            Corvo Co = new Corvo();
            Pinguino P = new Pinguino();
            Tonno T = new Tonno();
            SalmoneFluviale SF = new SalmoneFluviale();
            SalmoneMarino SM = new SalmoneMarino();


            U.Riepilogo();
            Console.WriteLine("\n \n");
            Ca.Riepilogo();
            Console.WriteLine("\n \n");
            Co.Riepilogo();
            Console.WriteLine("\n \n");
            P.Riepilogo();
            Console.WriteLine("\n \n");
            T.Riepilogo();
            Console.WriteLine("\n \n");
            SF.Riepilogo();
            Console.WriteLine("\n \n");
            SM.Riepilogo();

            Console.ReadLine();
        }
    }
}
