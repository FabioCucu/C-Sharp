using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ripasso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeriInteri;
            int dimensione = 10;

            CreaVettore(out numeriInteri, dimensione);
            Visualizza(numeriInteri, dimensione);
            Console.WriteLine("\n========================================================");
            //EstendiVettore(ref numeriInteri, 10);
            //Visualizza(numeriInteri);
            //Console.WriteLine("\n========================================================");
            CancellaDoppio(ref numeriInteri, ref dimensione);
            Visualizza(numeriInteri, dimensione);
            Console.ReadLine();
        }
        static void CreaVettore(out int[] numeriInteri, int dimensione)
        {
            numeriInteri = new int[dimensione];
            Random casuale = new Random();
            for (int i = 0; i < dimensione; i++)
            {
                numeriInteri[i] = casuale.Next(1, 101);
            }
        }
        static void Visualizza(int[] numeriInteri, int dimensione)
        {
            for (int i = 0; i < numeriInteri.Length; i++)
            {
                if (numeriInteri[i] != 0)
                {
                    Console.Write(numeriInteri[i] + " ");
                }
            }
        }
        //static void EstendiVettore(ref int[] numeriInteri, int estensione)
        //{
        //    int[] numeri = new int[numeriInteri.Length + estensione];
        //    Random casuale = new Random();
        //    for (int i = 0; i < numeri.Length; i++)
        //    {
        //        if (i < numeri.Length - estensione)
        //        {
        //            numeri[i] = numeriInteri[i];
        //        }
        //        else
        //        {
        //            numeri[i] = casuale.Next(1, 101);
        //        }
        //    }
        //    numeriInteri = numeri;
        //}
        static void CancellaDoppio(ref int[] numeriInteri, ref int dimensione)
        {
            for (int i = 0; i < numeriInteri.Length; i++)
            {
                for (int j = 0; j < dimensione; j++)
                {
                    if (j != i && numeriInteri[i] == numeriInteri[j])
                    {
                        numeriInteri[j] = 0;
                        dimensione--;
                    }
                }
            }
        }
        static int Indice(int[] numeriInteri, int numero)
        {
            for (int k = 0; k < numeriInteri.Length; k++)
            {
                if (numeriInteri[k] == numero)
                {
                    return 1;
                }
            }
            return -1;
        }
        static void Sposta (int[] numeriInteri, int posizione)
        {
            for (int k = 0; k < posizione; k++)
            {
                if (numeriInteri[k] == 0 && numeriInteri[k + 1] != 0)
                {
                    numeriInteri[k] = numeriInteri[k + 1];
                }
            }
        }
    }
}
//per casa: realizzare un metodo che permetta di togliere gli elementi duplicati del vettore numeri interi adattandone la dimensione
