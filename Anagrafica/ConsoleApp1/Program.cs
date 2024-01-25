using System;
using System.IO;

namespace MenuAnagrafe
{
    internal class Smenu
    {
        enum Sesso
        {
            maschio,
            femmina,
        }
        enum StatoCivile
        {
            Celibe,
            Nubile,
            Coniugato,
            Divorziato,
            Separato
        }
        struct persona
        {
            public string nome;
            public string cognome;
            public DateTime dataNascita;
            public StatoCivile statocivile;
            public Sesso sesso;
            public string cittadinanza;
            public int idFiscale;
            public int Età;
            public override string ToString()
            {
                return string.Format($"{nome,-15} {cognome,-15} {dataNascita.ToShortDateString(),-10} {statocivile,-10} {sesso,-10} {cittadinanza,-10}");
            }
        }
        static void Main(string[] args)
        {
            persona[] Cittadino = new persona[3];
            int i = 0;
            string titolo = "=====ANAGRAFICA=====", path = Path.Combine(Environment.CurrentDirectory + "\\" + "\\FileLog", "log"), csv = "";
            string[] opzioni = new string[] { "Inserimento", "Visualizza", "Modifica S.Civile", "Calcola età", "Cancella", "Leggi Log", "Elimina Log", "Scegli file di Log", "Salva csv ", "Importa csv", "Esci" };
            Menu(csv, opzioni, titolo, 10, 0, ConsoleColor.White, ConsoleColor.Green, ConsoleColor.Blue, Cittadino, i, path);
        }
        static void Menu(string csv, string[] opzioni, string titolo, int x, int y, ConsoleColor coloreTitolo, ConsoleColor coloreTesto, ConsoleColor coloreSfondo, persona[] Cittadino, int i, string path)
        {
            path = Path.Combine("DateTime.Now.ToShortDateString()" + "log");
            int temp = y;
            int scelta;
            int prova;
            y = temp;
            Console.ForegroundColor = coloreTitolo;
            Console.BackgroundColor = coloreSfondo;
            Console.Clear();
            do
            {

                GiustificaOpzione(opzioni, ref y, titolo);
                do
                {
                    prova = Convert.ToInt32(Console.ReadLine());
                } while (prova < 1 || prova > opzioni.Length);
                if (prova != opzioni.Length)
                {
                    scelta = prova;
                    Opzione(csv, scelta, Cittadino, ref i, path);
                }
            } while (prova != opzioni.Length);
        }
        static void Opzione(string csv, int scelta, persona[] Cittadino, ref int i, string path)
        {
            int id, pos;
            StatoCivile stato = StatoCivile.Coniugato;
            switch (scelta)
            {
                case 1:
                    if (i == Cittadino.Length)
                    {
                        Console.WriteLine("Hai inserito il numero massimo di persone");
                        Console.ReadLine();
                    }
                    else
                    {
                        Inserimento(Cittadino, ref i, path);
                    }
                    break;
                case 2:
                    Visualizza(Cittadino);
                    break;
                case 3:
                    Console.WriteLine("l'inserisci il tuo id");
                    id = Convert.ToInt32(Console.ReadLine());
                    if (IdVerififca(ref id, Cittadino, out pos))
                    {
                        Console.WriteLine("Sei Nubile(1) Coniugato/a(2) Divorziata/o(3) Separato/a(4) Celibe(5) ");
                        Cittadino[pos].statocivile = Stato(stato);
                    }
                    else
                    {
                        Console.WriteLine("Id invalido");
                    }
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 4:

                    Console.WriteLine("inserisci il tuo id");
                    id = Convert.ToInt32(Console.ReadLine());
                    if (IdVerififca(ref id, Cittadino, out pos))
                    {
                        Cittadino[pos].Età = ContaEtà(Cittadino[pos]);
                    }
                    else
                    {
                        Console.WriteLine("Id invalido");
                    }
                    break;
                case 5:

                    Console.WriteLine("inserisci il tuo id");
                    id = Convert.ToInt32(Console.ReadLine());
                    if (IdVerififca(ref id, Cittadino, out pos))
                    {
                        Cittadino[pos] = Cancella(Cittadino[pos]);
                    }
                    else
                    {
                        Console.WriteLine("Id invalido");
                    }
                    break;
                case 6:

                    bool controllo = LeggiLog(path);

                    if (controllo == false)
                    {
                        Console.WriteLine("Devi inserire almeno un cittadino");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    break;
                case 7:

                    File.Delete(path);
                    Console.Clear();
                    break;
                case 8:

                    GetFiles();
                    break;
                case 9:
                    StreamWriter Setcsv = new StreamWriter(Environment.CurrentDirectory + "\\log.csv");
                    foreach (persona e in Cittadino)
                    {
                        if (e.nome != null)
                        {
                            csv = string.Format($"{e.nome.ToString()}, {e.cognome.ToString()}, {e.cittadinanza.ToString()}, {e.dataNascita.ToString()}, {e.statocivile.ToString()}, {e.sesso.ToString()}, {e.idFiscale.ToString()}");
                            Setcsv.WriteLine(csv);
                        }
                    }
                    Setcsv.Close();
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 10:
                    StreamReader srRead = new StreamReader(Environment.CurrentDirectory + "\\log.csv");
                    csv = srRead.ReadLine();
                    string[] supporto = new string[8];
                    do
                    {
                        supporto = csv.Split(',');
                    } while (csv == null);
                    persona tizio = new persona();
                    tizio.nome = supporto[0];
                    tizio.cognome = supporto[1];
                    tizio.cittadinanza = supporto[2];
                    tizio.dataNascita = Convert.ToDateTime(supporto[3]);
                    switch (supporto[4])
                    {
                        case "Celibe":
                            tizio.statocivile = StatoCivile.Celibe;
                            break;
                        case "Nubile":
                            tizio.statocivile = StatoCivile.Nubile;
                            break;
                        case "Coniugato":
                            tizio.statocivile = StatoCivile.Coniugato;
                            break;
                        case "Divorziato":
                            tizio.statocivile = StatoCivile.Divorziato;
                            break;
                        case "Separato":
                            tizio.statocivile = StatoCivile.Separato;
                            break;
                    }
                    if (supporto[5] == "maschio")
                    {
                        tizio.sesso = Sesso.maschio;
                    }
                    else
                    {
                        tizio.sesso = Sesso.femmina;
                    }
                    tizio.idFiscale = Convert.ToInt16(supporto[6]);
                    Console.Clear();
                    break;
            }
        }
        static void GiustificaOpzione(string[] frase, ref int y, string TITOLO)
        {
            Console.SetCursorPosition(10, 0);
            Console.WriteLine(TITOLO);
            y++;
            for (int i = 0; i < frase.Length; i++)
            {
                Console.SetCursorPosition(10, i + 1);
                Console.WriteLine($"[{i + 1}] {frase[i]} ");
                y++;
            }
        }
        static void Inserimento(persona[] Cittadino, ref int i, string path)
        {
            bool ok;
            string data;
            int anno, mese, giorno, id, pos;
            Sesso tipo;
            if (i < 3)
            {
                Console.Clear();
                StatoCivile stato = StatoCivile.Separato;
                Console.WriteLine("Inserisci il tuo nome");
                Cittadino[i].nome = Console.ReadLine();
                Console.WriteLine("Inserisci il tuo cognome");
                Cittadino[i].cognome = Console.ReadLine();
                do
                {
                    Console.WriteLine("Inserisci la tua data di nascità");
                    data = Console.ReadLine();
                    EstraiData(data, out anno, out mese, out giorno);
                    ok = VerfificaData(anno, mese, giorno);
                } while (ok);
                Cittadino[i].dataNascita = Convert.ToDateTime(data);
                Console.WriteLine("Inserisci la tua cittadinanza");
                Cittadino[i].cittadinanza = Console.ReadLine();
                Console.WriteLine("Sei Nubile(1) Coniugato/a(2) Divorziata/o(3) Separato/a(4) Celibe(5) ");
                Cittadino[i].statocivile = Stato(stato);
                Console.WriteLine("che sesso sei? Maschio [1] o femmina [2]");
                int scelta = Convert.ToInt32(Console.ReadLine());
                Cittadino[i].sesso = gender(scelta, out tipo);
                do
                {
                    Console.WriteLine("inserisci il tuo Id fiscale");
                    id = Convert.ToInt32(Console.ReadLine());
                } while (IdVerififca(ref id, Cittadino, out pos));
                Cittadino[i].idFiscale = id;

                ScriviLog(Cittadino[i].ToString(), path);

                i++;
            }
            else
            {
                Console.WriteLine("Non ce più spazio per l'inserimento");
                return;
            }
            Console.ReadLine();
            Console.Clear();
        }
        static bool IdVerififca(ref int id, persona[] cittadino, out int pos)
        {
            pos = 0;
            for (int i = 0; i < cittadino.Length; i++)
            {
                if (id == cittadino[i].idFiscale)
                {
                    pos = i;
                    return true;
                }
            }
            return false;
        }
        static void EstraiData(string data2, out int anno2, out int mese2, out int giorno2)
        {
            string[] array = data2.Split('/');
            giorno2 = Convert.ToInt32(array[0]);
            mese2 = Convert.ToInt32(array[1]);
            anno2 = Convert.ToInt32(array[2]);
        }
        static void Visualizza(persona[] Cittadino)
        {
            Console.WriteLine("=============================================================================");
            for (int i = 0; i < Cittadino.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(Cittadino[i].nome) && String.IsNullOrEmpty(Cittadino[i].cognome))
                {
                    Console.ReadLine();
                    Console.Clear();
                    return;
                }
                else
                {
                    Console.WriteLine("nome:{0}", Cittadino[i].nome);
                    Console.WriteLine("cognome:{0}", Cittadino[i].cognome);
                    Console.WriteLine("nascità:{0}", Cittadino[i].dataNascita.ToShortDateString().ToString());
                    Console.WriteLine("stato civile:{0}", Cittadino[i].statocivile.ToString());
                    Console.WriteLine("sesso:{0}", Cittadino[i].sesso.ToString());
                    Console.WriteLine("cittadinanza:{0}", Cittadino[i].cittadinanza);
                    Console.WriteLine("Id Fiscale:{0}", Cittadino[i].idFiscale);
                    Console.WriteLine("=============================================================================");
                }
            }
            Console.ReadLine();
            Console.Clear();
        }
        static persona Cancella(persona cittadino)
        {
            cittadino = new persona();
            Console.Clear();
            return cittadino;
        }
        static int ContaEtà(persona Cittadino)
        {
            int dataToday = DateTime.Today.Year;
            int dataNascità, età = 0;
            dataNascità = Cittadino.dataNascita.Year;
            if (dataNascità <= dataToday)
            {
                età = dataToday - dataNascità;
            }
            else
            {
                Console.WriteLine("Data invalida");
            }
            età--;
            Console.WriteLine($"{Cittadino.nome} {Cittadino.cognome} età {età}");
            Console.ReadLine();
            Console.Clear();
            return età;
        }
        static StatoCivile Stato(StatoCivile stato)
        {
            bool controllo;
            int opzione = 0;
            do
            {
                try
                {
                    controllo = false;
                    opzione = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    controllo = true;
                }
            } while (controllo == true);

            switch (opzione)
            {
                case 1:
                    stato = StatoCivile.Nubile;
                    break;
                case 2:
                    stato = StatoCivile.Coniugato;
                    break;
                case 3:
                    stato = StatoCivile.Divorziato;
                    break;
                case 4:
                    stato = StatoCivile.Separato;
                    break;
                case 5:
                    stato = StatoCivile.Celibe;
                    break;
            }
            return stato;
        }
        static Sesso gender(int scelta, out Sesso tipo)
        {
            tipo = Sesso.maschio;
            switch (scelta)
            {
                case 2:
                    tipo = Sesso.femmina;
                    break;
            }
            return tipo;
        }
        static bool VerfificaData(int anno, int mese, int giorno)
        {
            bool controllo = false;
            if (anno < 0)
            {
                controllo = true;
            }
            else if (mese < 0 || mese > 12)
            {
                controllo = true;
            }
            if (mese == 1 || mese == 3 || mese == 5 || mese == 7 || mese == 8 || mese == 10 || mese == 12)
            {
                if (Convert.ToInt32(giorno) > 31)
                {
                    controllo = true;
                }
            }
            else if (mese == 4 || mese == 6 || mese == 7 || mese == 11)
            {
                if (Convert.ToInt32(giorno) > 30)
                {
                    controllo = true;
                }
            }
            else if (mese == 2)
            {
                if (Convert.ToInt32(giorno) > 29)
                {
                    controllo = true;
                }
            }
            return controllo;
        }
        static void ScriviLog(string logstring, string path)
        {
            StreamWriter sw;
            if (File.Exists(path))
            {
                sw = new StreamWriter(path, true);
            }
            else
            {
                sw = new StreamWriter(path);
            }
            sw.WriteLine(DateTime.Now + " " + logstring);
            sw.Close();
        }
        static bool LeggiLog(string path)
        {
            try
            {
                StreamReader sr = File.OpenText(path);
                string lineaTesto;
                lineaTesto = sr.ReadLine();
                while (lineaTesto != null)
                {
                    Console.WriteLine(lineaTesto);
                    lineaTesto = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            Console.ReadLine();
            Console.Clear();
            return true;
        }
        static string CostruisciLog(DateTime datatAttuale)
        {
            string data = datatAttuale.ToShortDateString();
            data = data.Replace("/", ".");
            return data;
        }
        static void GetFiles()
        {
            bool controllo;
            string[] files;
            files = Directory.GetFiles(Environment.CurrentDirectory + "\\" + "\\FileLog");
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] log {files[i]}");
            }
            if (files != null)
            {
                do
                {
                    controllo = true;
                    try
                    {
                        Console.WriteLine("=======================================================");
                        Console.WriteLine("Scegli il log da leggere");
                        int scelta = Convert.ToInt32(Console.ReadLine()) - 1;
                        LeggiLog(files[scelta]);
                    }
                    catch
                    {
                        controllo = false;
                    }
                } while (controllo == false);
            }
            Console.Clear();
        }
        static void SaveCSV()
        {
            StreamWriter csv;
        }
        static void ImportaCSV()
        {
            StreamWriter csv;
        }
    }
    //si vuole scegliere uno dei file di log presenti all'interno della directory di lavoro dall'elenco dei file all'interno della stessa
    //i file dovranno essere visualizzati utilizzando il metodo menù dal quale l'utente può scegliere uno dei file di log.
}