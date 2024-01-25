using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lo_zoo_di_casa_mia
{
    internal class Class1
    {
        enum mangiato
        {
            deveMangiare,
            giàMangiato,
            nonPuòMangiare
        }
        internal class AnimaleDomestico
        {
            //proprietà
            string specie;
            string razza;
            string verso;
            int quantità;
            mangiato stato;

            //metodo costruttore
            public AnimaleDomestico()
            {

            }
            public AnimaleDomestico(string specie, string razza, int quantità)
            {
                this.specie = specie;
                this.razza = razza;
                this.quantità = quantità;
            }
            public AnimaleDomestico(string specie, string razza)
            {
                this.specie = specie;
                this.razza = razza;
            }
            //metodi getters and setters
            public void Setspecie(string specie)
            {
                this.specie = specie;
            }
            public void Setrazza(string razza)
            {
                this.razza = razza;
            }
            public void Setverso(string verso)
            {
                this.verso = verso;
            }
            public void Setquantità(int quantità)
            {
                this.quantità = quantità;
            }
            public string Getspecie()
            {
                return specie;
            }
            public string Getrazza()
            {
                return razza;
            }
            public string Getverso()
            {
                return verso;
            }
            public int Getquantità()
            {
                return quantità;
            }
        }
    }
}
