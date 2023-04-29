using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuolaElementare
{
    class Program
    {
        static void Main(string[] args)
        {
            string ricerca;
            string[] nomeAlunni = new string[3];
            int opzione, alunni = 0;
            bool ciclo = true, trovato = false;
            const int nAlunni = 3;
            do
            {
                do
                {
                    Console.WriteLine("===Registro di classe===");
                    Console.WriteLine("[1] inserimento");
                    Console.WriteLine("[2] esci");
                    Console.WriteLine("[3] ricerca");
                    Console.WriteLine("[4] ricerca posizione");
                    opzione = Convert.ToInt32(Console.ReadLine());
                } while (opzione < 1 || opzione > 2);
                switch (opzione)
                {
                    case 1:
                        if(nAlunni != alunni)
                        {
                            Console.WriteLine($"Inserire il nome del {alunni + 1}° alunno");
                            nomeAlunni[alunni] = Console.ReadLine();
                            Console.WriteLine($"Mancano {3 - (alunni)} nomi da inserire");
                            alunni++;
                        }
                        break;
                    case 2:
                        if (alunni != 0)
                        {
                            for (int i = 0; i)
                            Console.WriteLine()
                        }
                        else
                        {
                            Console.WriteLine("Non hai inserito tutti gli alunni");
                        }
                        break;
                    case 3:
                        for(int i = 0; i <)
                        {
                            if ()
                            {
                                trovato = true;
                            }
                        }
                        trovato = opzione == ;
                        break;

                }
            } while (ciclo == true);
            Console.ReadLine();
        }
    }
}
//Realizzare una ricerca che permetta di determinare la posizione di un alunno
//Verificare che la ricerca inserita nel punto 3 potrebbe essere costituita nella posizione 4