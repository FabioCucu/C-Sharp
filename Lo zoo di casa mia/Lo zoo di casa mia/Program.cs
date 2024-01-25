using System;
using static Lo_zoo_di_casa_mia.Class1;

namespace Lo_zoo_di_casa_mia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int animaliMax, animaliIns = 0, scelta = -1;
            Console.WriteLine("Quanti animali vuoi inserire?");
            animaliMax = Convert.ToInt32(Console.ReadLine());
            AnimaleDomestico[] zoo = new AnimaleDomestico[animaliMax];
            string titolo = "===== Lo Zoo Di Casa Mia =====";
            string[] opzioni = new string[] { "Inserimento", "Visualizza", "Esci" };
            do
            {
                Menu(titolo, opzioni, animaliIns, animaliMax, zoo, ref scelta);
            } while (scelta != 3);
        }
        static void Menu(string titolo, string[] opzioni, int animaliIns, int animaliMax, AnimaleDomestico[] zoo, ref int scelta)
        {
            Console.WriteLine(titolo);
            for (int i = 0; i < opzioni.Length; i++)
            {
                Console.SetCursorPosition(10, i + 1);
                Console.WriteLine($"[{i + 1}] {opzioni[i]} ");
            }
            scelta = Convert.ToInt32(Console.ReadLine());
            Opzione(scelta, zoo, animaliMax, animaliIns);
        }
        static void Opzione(int scelta, AnimaleDomestico[] zoo, int animaliMax, int animaliIns)
        {
            switch (scelta)
            {
                case 1:
                    if (animaliMax == zoo.Length)
                    {
                        Console.WriteLine("Hai inserito il numero massimo di persone");
                        Console.ReadLine();
                    }
                    else
                    {
                        animaliIns++;
                        Inserimento(zoo, animaliIns);
                    }
                    break;
                case 2:
                    Visualizza(zoo);
                    break;
            }
        }
        static void Inserimento(AnimaleDomestico[] zoo, int animaliIns)
        {
            Console.Clear();
            Console.WriteLine("Inserisci la specie");
            zoo[animaliIns].Setspecie(Console.ReadLine());
            Console.WriteLine("Inserisci la razza");
            zoo[animaliIns].Setrazza(Console.ReadLine());
            Console.WriteLine("Inserisci il verso");
            zoo[animaliIns].Setverso(Console.ReadLine());
            Console.WriteLine("Inserisci la quantità");
            zoo[animaliIns].Setquantità(Convert.ToInt16(Console.ReadLine()));
            Console.ReadLine();
            Console.Clear();
        }
        static void Visualizza(AnimaleDomestico[] zoo)
        {
            Console.WriteLine("=============================================================================");
            for (int i = 0; i < zoo.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(zoo[i].Getspecie()))
                {
                    Console.WriteLine("Non hai inserito nulla");
                    Console.ReadLine();
                    Console.Clear();
                    return;
                }
                else
                {
                    Console.WriteLine("specie:{0}", zoo[i].Getspecie());
                    Console.WriteLine("razza:{0}", zoo[i].Getrazza());
                    Console.WriteLine("nascità:{0}", zoo[i].Getverso());
                    Console.WriteLine("stato civile:{0}", zoo[i].Getquantità());
                    Console.WriteLine("=============================================================================");
                }
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
