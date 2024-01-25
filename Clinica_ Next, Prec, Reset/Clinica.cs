using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal class Reparto
    {
        string reparto;
        List<Paziente> pazienti;
        Termometro termometro;
        int nPazienti;
        public Reparto(string reparti)
        {
            nPazienti = 5;
            this.reparto = reparti;
            this.pazienti = new List<Paziente>(nPazienti);
            this.termometro = new Termometro();
        }

        public Reparto(string reparti, int nPazienti) 
        {
            this.nPazienti = nPazienti;
            this.pazienti = new List<Paziente>(nPazienti);
            this.termometro = new Termometro();
            this.reparto = reparti;
        }

        public void AddPazienti(Paziente pazienti) 
        {
            if(this.pazienti.Count < nPazienti) 
            {
                this.pazienti.Add(pazienti);
            }
            else
            {
                throw new Exception("reparto pieno impossibile aggiungere altri pazienti");
            }
        }

        public List<Paziente> copyPaz()
        {
            List<Paziente> Copia = this.pazienti;
            return Copia;
        }
    }
}
