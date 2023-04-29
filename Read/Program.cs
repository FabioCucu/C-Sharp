using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read
{
    class Program
    {
        static void Main(string[] args)
        {
            string risposta, stringalettere = "", stringanumeri = "";
            char tastoCh;
            int tasto = Console.Read();//Ritorna il valore in codifica ASCII e UTF8
            //tastoCh = Convert.ToChar(tasto);
            //Console.WriteLine(tasto);
            //tasto = Console.Read();
            //Console.WriteLine(tasto);
            //tasto = Console.Read();
            //Console.WriteLine(tasto);
            //tasto = Console.Read();
            //Console.ReadLine();
            do
            {
                do
                {
                    tasto = Console.Read();
                    if (Char.IsLetter)
                    {
                        stringalettere = stringalettere + Convert.ToChar(tasto);
                    }
                    if (tasto > 48 && tasto < 56)
                    {
                        stringanumeri = stringanumeri + Convert.ToChar(tasto);
                    }
                    tastoCh = Convert.ToChar(tasto);
                } while (tasto != 13);
                Console.WriteLine("Vuoi continuare?");
                risposta = Console.ReadLine().ToLower();
            } while (risposta == "si");
            
        }
    }
}
