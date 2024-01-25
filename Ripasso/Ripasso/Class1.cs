using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ripasso
{
    internal class Flotta
    {
        string nome;
        string autorizzazione;
        List<Auto>
        public Flotta()
        {

        }
        public Flotta(string nome)
        {
            this.nome = nome;
            const int lunghezza = 6;
            int numero;
            string autoStatale = "";
            char lettera;
            Random rand = new Random();
            for (int i = 0; i <= lunghezza; i++)
            {
                if (i < 5)
                {
                    numero = rand.Next(1, 10);
                    autoStatale = autoStatale + numero;
                }
                else
                {
                    numero = rand.Next(65, 91);
                    lettera = Convert.ToChar(numero);
                    autoStatale = autoStatale + lettera;

                }
            }
            this.autorizzazione = autoStatale;
        }
        public string getAutorizzazione()
        {
            return autorizzazione;
        }
    }
}
