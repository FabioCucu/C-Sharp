using System;
using System.Collections.Generic;

namespace Verifica4F
{
    internal class Program
    {
        struct Studente
        {
            public string nome;
            public string cognome;
            public int voto;
            public DateTime nascita;
        }
        static void Main(string[] args)
        {
            //Fabio Cucu 4F 24/10/2023 FILA A;

            int nStudenti = 0;
            Console.WriteLine("Inserisci quanti studenti fanno parte della classe");
            do
            {
                try//Controllo se il numero degli studenti inserito dall'utente è accettabile
                {
                    nStudenti = Convert.ToInt16(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Hai inserito un valore non accettabile");
                }
            } while (nStudenti <= 0);//ciclo per richiedere l'inserimento in caso il numero degli studenti inserito dall'utente non sia accettabile
            Console.Clear();
            List<Studente> classe = new List<Studente>();
            Menu(nStudenti, classe);
            Console.WriteLine("Fine Programma");
        }
        static void Menu(int nStudenti, List<Studente> classe)
        {
            const int maxOpzioni = 4;
            int opzione, controllo;
            do
            {
                controllo = 0;
                Console.WriteLine("==========================");
                Console.WriteLine("[1] Inserisci studente");
                Console.WriteLine("[2] Visualizza classe");
                Console.WriteLine("[3] Visualizza maggiorenni");
                Console.WriteLine("[4] Esci");
                Console.WriteLine("==========================");
                opzione = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                controllo = Scelta(opzione, nStudenti, classe);
                if (controllo == -1)
                {
                    Console.WriteLine("Hai raggiunto il numero massimo di studenti");
                }
            } while (opzione != maxOpzioni);
        }
        static int Scelta(int opzione, int nStudenti, List<Studente> classe)
        {
            switch (opzione)
            {
                case 1:
                    if (classe.Count < nStudenti)
                    {
                        Inserimento(classe);
                    }
                    else
                    {
                        return -1;
                    }
                    break;
                case 2:
                    Visualizza(classe);
                    break;
                case 3:
                    bool[] maggiorenni = Maggiorenni(classe);
                    VisualizzaMaggiorenni(classe, maggiorenni);
                    break;
            }
            Console.ReadLine();
            Console.Clear();
            return 0;
        }
        static void Inserimento(List<Studente> classe)
        {
            Studente c1 = new Studente();
            Console.WriteLine($"STUDENTE #{classe.Count + 1}:\n===========================================");
            Console.WriteLine("Inserisci il nome dello studente");
            c1.nome = Console.ReadLine();
            Console.WriteLine("Inserisci il cognome dello studente");
            c1.cognome = Console.ReadLine();
            if (classe.Exists(e => e.nome == c1.nome && e.cognome == c1.cognome))
            {
                Console.WriteLine("Questo studente è già stato inserito");
                return;
            }
            do
            {
                try//Controllo che il voto sia di un tipo accettabile (int)
                {
                    Console.WriteLine("Inserisci il voto dello studente");
                    c1.voto = Convert.ToInt16(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Hai inserito un valore non accettabile");
                }
            } while (c1.voto < 0 || c1.voto > 10);//Controllo che il voto sia compreso tra i limiti (0-10)
            Console.WriteLine("Inserisci la data di nascita dello studente");
            //int controllo = -1;
            do
            {
                try//Controllo che la data sia daccettabile
                {
                    c1.nascita = Convert.ToDateTime(Console.ReadLine());
                    //controllo = ControlloData(classe, studentiIns);//Non completo
                    //if (controllo != 0) 
                    //{
                    //    Console.WriteLine("Hai inserito una data non accettabile(DD/MM/YYYY)");
                    //}
                }
                catch
                {
                    Console.WriteLine("Hai inserito un valore non accettabile (DD/MM/YYYY)");
                    
                }
            } while (c1.nascita == null /*&& controllo == -1*/);//Controllo che la data non rimanga vuota dopo un inserimento errato
            classe.Add(c1);
        }
        static void Visualizza(List<Studente> classe)
        {
            for (int i = 0; i < classe.Count; i++)
            {
                if (classe[i].nome != null)//controllo che l'array non sia vuoto, così non vengono stampati studenti vuoti
                {
                    Console.WriteLine($"STUDENTE #{i + 1}:\n===========================================");
                    Console.WriteLine($"Nome: {classe[i].nome}");
                    Console.WriteLine($"Cognome: {classe[i].cognome}");
                    Console.WriteLine($"Voto: {classe[i].voto}");
                    Console.WriteLine($"Data di nascita: {classe[i].nascita}");
                    Console.WriteLine("===========================================");
                }

            }
        }
        static bool[] Maggiorenni(List<Studente> classe)
        {
            bool[] maggiorenni = new bool[classe.Count];//Dichiaro un array di bool che mi salverà il risultato della sottrazione
            for (int i = 0; i < classe.Count; i++)
            {
                if (DateTime.Now.Year - classe[i].nascita.Year >= 18)//Controllo se l'alunno è maggiorenne sottranedo al suo anno di nascita, l'anno di oggi
                {
                    maggiorenni[i] = true;
                }
                else
                {
                    maggiorenni[i] = false;
                }
            }
            return maggiorenni;
        }
        static void VisualizzaMaggiorenni(List<Studente> classe, bool[] maggiorenni)
        {
            for (int i = 0; i < classe.Count; i++)
            {
                if (classe[i].nome != null && maggiorenni[i] == true)//Controllo che lo spazio dell'array non sia vuoto e sia maggiorenne usando l'array di bool
                {
                    Console.WriteLine($"STUDENTE #{i + 1}:\n===========================================");
                    Console.WriteLine($"Nome: {classe[i].nome}");
                    Console.WriteLine($"Cognome: {classe[i].cognome}");
                    Console.WriteLine($"Voto: {classe[i].voto}");
                    Console.WriteLine($"Data di nascita: {classe[i].nascita}");
                    Console.WriteLine("===========================================");
                }

            }
        }
        //static int ControlloData(List<Studente> classe, int studenteIns)//Non completo
        //{
        //    if (classe[studenteIns].nascita.Month == 2 && classe[studenteIns].nascita.Day <= 29)
        //    {
        //        return 0;
        //    }
        //    else if (classe[studenteIns].nascita.Month == 10 && classe[studenteIns].nascita.Day <= 31)
        //    {
        //        return 0;
        //    }
        //}
    }
}
