using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal class Program
    {
        static int Menu(string[] opzioni, string titolo)
        {
            Console.Clear();
            int scelta;
            bool valid;
            string errore = "Attenzione la tua opzione non è valida riprova premendo un tasto qualsiasi";
            do
            {
                Console.WriteLine("====={0}=====", titolo);
                for (int i = 0; i < opzioni.Length; i++)
                {
                    Console.WriteLine($"[{i + 1}] {opzioni[i]}\n");
                }
                Console.Write("==========");
                for (int i = 0; i < titolo.Length; i++)
                {
                    Console.Write("=");
                }
                Console.WriteLine("\n\nInserisci l'opzione (1-{0})", opzioni.Length);
                if (!(valid = int.TryParse(Console.ReadLine(), out scelta)) || scelta < 1 || scelta > opzioni.Length)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(errore);
                    Console.ReadKey(true);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                }
            } while (!valid || scelta < 1 || scelta > opzioni.Length);
            Console.Clear();
            return scelta;
        }
        static void Main(string[] args)
        {
            string[] optionP = new string[] { "inserimento","cambia temperatura ","exit" };
            List<Reparto> clinica = new List<Reparto>();
            int scelta;
            do
            {
                scelta = Menu(optionP, "Clinica");
                switch (scelta)
                {
                    case 1:
                        
                        break;
                    case 2:
                        
                        break;
                    case 3:

                        break;
                }
            } while (scelta != optionP.Length + 1);
        }
        static void ModificaTemperatura(string nome, string cognome)
        {

        }
    }
}
