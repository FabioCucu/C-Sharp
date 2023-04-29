using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rettangolo
{
    //Scopo: Calcolo dell'area del rettangolo
    class Program
    {
        static void Main(string[] args)
        {//dichiarazione/assegnazione variabili
            int baseR = 5, AltR = 4, Area, Perimetro;
         //Calcolo dell'area
            Area = baseR * AltR;
         //Calclo del perimetro
            Perimetro = (baseR + AltR) * 2;
         //Visualizzazione dei risultati
            Console.Write("La base del rettangolo è: "); Console.WriteLine(baseR);
            Console.Write("L'altezza del rettangolo è: "); Console.WriteLine(AltR);
            Console.Write("L'area del rettangolo è: "); Console.WriteLine(Area);
            Console.Write("Il perimetro del rettangolo è: "); Console.WriteLine(Perimetro);
            Console.WriteLine("Premi un tasto per concludere il processo");
            Console.ReadLine();
        }
    }
}
