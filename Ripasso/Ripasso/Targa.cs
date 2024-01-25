using Ripasso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ripasso
{
    internal class Targa
    {
        static string targa;
        static Governo()
        {
            targa = GeneraTarga();
        }
        public static string Targa()
        {
            return targa;
        }
        private static string GeneraTarga()
        {
            const int lunghezza = 8;
            int numero, cont = 0;
            string targaFinale = "";
            char lettera;
            Random targa = new Random();
            for (int i = 0; i <= lunghezza; i++)
            {
                if (i > 1 && i < 7)
                {
                    cont++;
                    numero = targa.Next(1, 10);
                    if (cont == 3 || cont == 7)
                    {
                        targaFinale = targaFinale + " ";
                    }
                    else
                    {
                        targaFinale = targaFinale + numero;
                    }
                }
                else
                {
                    cont++;
                    numero = targa.Next(65, 91);
                    lettera = Convert.ToChar(numero);
                    targaFinale = targaFinale + lettera;
                }
            }
            Console.WriteLine(targaFinale);
            return targaFinale;
        }
    } 
}
