using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string giorno;
            Console.WriteLine("Inserisci il giorno della settimana");
            giorno = Console.ReadLine();
            //if (giorno == "lunedì")
            //{
            //    Console.WriteLine("E' il primo giorno della settimana");
            //}
            //else
            //{
            //    if (giorno == "martedì")
            //    {
            //        Console.WriteLine("E' il secondo giorno della settimana");
            //    }
            //    else
            //    {
            //        if (giorno == "mercoledì")
            //        {
            //            Console.WriteLine("E' il terzo giorno della settimana");
            //        }
            //        else
            //        {
            //            if (giorno == "giovedì")
            //            {
            //                Console.WriteLine("E' il quarto giorno della settimana");
            //            }
            //            else
            //            {
            //                if (giorno == "venerdì")
            //                {
            //                    Console.WriteLine("E' il quinto giorno della settimana");
            //                }
            //                else
            //                {
            //                    if (giorno == "sabato")
            //                    {
            //                        Console.WriteLine("E' il sesto giorno della settimana");
            //                    }
            //                    else
            //                    {
            //                        if (giorno == "domenica")
            //                        {
            //                            Console.WriteLine("E' il settimo/ultimo giorno della settimana");
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("giorno sbagliato");
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            //Console.ReadLine();
            switch (giorno)
            {
                case ("lunedì"):
                    Console.WriteLine("E' il primo giorno della settimana");
                    break;
                case ("martedì"):
                    Console.WriteLine("E' il primo giorno della settimana");
                    break;
                case ("mercoledì"):
                    Console.WriteLine("E' il primo giorno della settimana");
                    break;
                case ("giovedì"):
                    Console.WriteLine("E' il primo giorno della settimana");
                    break;
                case ("venerdì"):
                    Console.WriteLine("E' il primo giorno della settimana");
                    break;
                case ("sabato"):
                    Console.WriteLine("E' il primo giorno della settimana");
                    break;
                case ("domenica"):
                    Console.WriteLine("E' il primo giorno della settimana");
                    break;
                default:
                    Console.WriteLine("giorno sbagliato");
                    break;
            }
        }
    }
}