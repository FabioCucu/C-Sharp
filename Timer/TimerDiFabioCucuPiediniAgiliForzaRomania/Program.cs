using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimerDiFabioCucuPiediniAgiliForzaRomania
{
    internal class Program
    {
            static int contatore = 0;
        static Timer myTimer = new Timer();
        static void Main(string[] args)
        {
            ConsoleKeyInfo tasto;
            myTimer.Elapsed += new ElapsedEventHandler(OnTimer);
            myTimer.Interval =1000;
            myTimer.Enabled = true;
            Console.WriteLine("premi enter per terminare");
            tasto = Console.ReadKey();
            while(tasto.Key != ConsoleKey.Enter)
            {
                if(bConta )
                Console.WriteLine(contatore);
            }
        }
        static public void OnTimer(object sender, ElapsedEventArgs e)
        {
            contatore++;
        }
    }
}
