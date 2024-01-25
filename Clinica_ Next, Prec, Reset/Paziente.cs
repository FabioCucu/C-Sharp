using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal class Paziente
    {
        string nome;
        string cognome;
        string reparto;
        double temperatura;

        public Paziente( string nome, string cognome, string reparto, double temperatura)
        {
            SetNome(nome);
            this.cognome = cognome;
            this.reparto = reparto;
            this.temperatura = temperatura;
        }

        public Paziente() 
        {
            this.temperatura = 36;
        }

        public string getNome() 
        {
            return nome;
        }

        private void SetNome(string nome) 
        {
            this.nome = nome;
        }

        public string getCognome() 
        {
            return cognome;
        }

        public string getReparto()
        {
            return reparto;
        }

        public void setReparto(string reparto)
        {
            this.reparto = reparto;
        }

        public double getTemperatura()
        {
            return temperatura;
        }

        public void setTemperatura(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public string Anagrafica()
        {
            return string.Format($"{nome, -20}{cognome, -20}{reparto, -20}{temperatura, -20}");
        }
    }
}
