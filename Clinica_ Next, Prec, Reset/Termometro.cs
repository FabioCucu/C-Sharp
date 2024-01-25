using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal class Termometro
    {
        double temperatura;

        public Termometro() 
        {
            temperatura = 36;
        }

        public void setTemperatura(double temperatura)
        {
            this.temperatura = temperatura;
        }
        
        public double getTemperatura() 
        {
            return temperatura;
        }
    }
}
