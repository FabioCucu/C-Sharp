using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipassoMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            int scelta = 0;

            do
            {
                scelta = Menù();
                switch (scelta)
                {
                    case 1:
                        inserimento();
                        break;
                    case 2:
                        ricerca();
                        break;
                    case 3:
                        visualizza();
                        break;
                    case 4:
                        modifica();
                        break;
                    case 5:
                        elimina();
                        break;
                    default:
                        Console.WriteLine("Questa scelta non esiste");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }

            } while (scelta < 1 || scelta > 6);
        }
        static int Menù()
        {
            const string titolo = "Ufficio anagrafe";
            string[] opzioni = { "insertimento", "ricerca", "visualizza", "modifica", "elimina", "uscita" };
            string[] sesso = { "maschio", "femmina" };
            int scelta;
            Console.WriteLine($"============== {titolo} ==============");
            Console.WriteLine($"{opzioni[0]}");
            Console.WriteLine($"{opzioni[1]}");
            Console.WriteLine($"{opzioni[2]}");
            Console.WriteLine($"{opzioni[3]}");
            Console.WriteLine($"{opzioni[4]}");
            Console.WriteLine($"{opzioni[5]}");
            Console.WriteLine($"====================================");
            Console.WriteLine("Scegli l'opzione");
            scelta = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return scelta;
        }
        static void inserimento()
        {

        }
        static void ricerca()
        {

        }
        static void visualizza()
        {

        }
        static void modifica()
        {

        }
        static void elimina()
        {

        }
    }
}
