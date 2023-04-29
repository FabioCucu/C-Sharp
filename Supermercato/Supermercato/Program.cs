using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercato
{
    class Program
    {
        static void Main(string[] args)
        {
            double totale, prezzoScontato;
            string spesa;
            Console.WriteLine("Inserisci l'importo totale da pagare");
            spesa = Console.ReadLine();
            if (spesa == "")
            {
                Console.WriteLine("Non hai inserito nulla");
            }
            else
            {
                totale = Convert.ToDouble(spesa);
                if (totale == 0)
                {
                    Console.WriteLine("Hai inserito un valore non valido");
                }
                else 
                {
                    if (totale < 50)
                    {
                        Console.WriteLine("Lo sconto è del 5%");
                        prezzoScontato = totale * 0.05;
                    }
                    else if (totale < 65)
                    {
                        Console.WriteLine("Lo sconto è del 6%");
                        prezzoScontato = totale * 0.06;
                    }
                    else if (totale < 80)
                    {
                        Console.WriteLine("Lo sconto è del 7%");
                        prezzoScontato = totale * 0.07;
                    }
                    else
                    {
                        Console.WriteLine("Lo sconto è del 10%");
                        prezzoScontato = totale * 0.1;
                    }
                    Console.WriteLine($"Il totale dell'importo scontato è: {totale - prezzoScontato}");
                }
            }
            Console.ReadLine();
        }
    }
}
