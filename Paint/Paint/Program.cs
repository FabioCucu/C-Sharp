using System;

namespace Paint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey tasto;
            bool Ins = false, canc = false;
            int riga = 0, colonna = 0;
            char matita = '*';
            char[,] undo = new char[Console.WindowWidth - 3, Console.WindowHeight - 3];
            char[,] salvataggioSchermo = new char[Console.WindowHeight - 3, Console.WindowWidth - 3];
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            for (int i = 0; i < Console.WindowHeight; i++)
                do
                {
                    Console.SetCursorPosition(riga, colonna);

                    tasto = Console.ReadKey(true).Key;
                    switch (tasto)
                    {
                        case ConsoleKey.LeftArrow:
                            if (riga > 0)
                            {
                                riga--;
                                Console.SetCursorPosition(riga, colonna);
                                if (!Ins)
                                {
                                    Console.Write(matita);
                                }
                                if (canc)
                                {
                                    Console.Write(" ");
                                }
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            if (riga < Console.WindowWidth - 1)
                            {
                                riga++;
                                Console.SetCursorPosition(riga, colonna);
                                if (!Ins)
                                {
                                    Console.Write(matita);
                                }
                                if (canc)
                                {
                                    Console.Write(" ");
                                }
                            }
                            break;
                        case ConsoleKey.UpArrow:
                            if (colonna > 0)
                            {
                                colonna--;
                                Console.SetCursorPosition(riga, colonna);
                                if (!Ins)
                                {
                                    Console.Write(matita);
                                }
                                if (canc)
                                {
                                    Console.Write(" ");
                                }
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            if (colonna < Console.WindowHeight - 1)
                            {
                                colonna++;
                                Console.SetCursorPosition(riga, colonna);
                                if (!Ins)
                                {
                                    Console.Write(matita);
                                }
                                if (canc)
                                {
                                    Console.Write(" ");
                                }
                            }
                            break;
                        case ConsoleKey.Delete:
                            if (!canc)
                            {
                                canc = true;
                                Ins = true;
                            }
                            else
                            {
                                canc = false;
                                Ins = false;
                            }
                            break;
                        case ConsoleKey.Insert:
                            if (!Ins)
                            {
                                Ins = true;
                            }
                            else
                            {
                                Ins = false;
                            }
                            break;
                        case ConsoleKey.F3:
                            matita = Convert.ToChar(Console.ReadLine());
                            Console.SetCursorPosition(riga, colonna);
                            Console.Write(" ");
                            break;
                        case ConsoleKey.Enter:
                            Console.Clear();
                            break;
                        case ConsoleKey.F1:
                            for (int j = 0; j < Console.WindowWidth - 3; j++)
                            {
                                for (int k = 0; k < Console.WindowHeight - 3; k++)
                                {
                                    salvataggioSchermo[k, j] = undo[k, j];
                                }
                            }
                            break;
                        case ConsoleKey.F2:
                            for (int j = 0; j < Console.WindowHeight - 3; j++)
                            {
                                for (int k = 0; k < Console.WindowWidth - 3; k++)
                                {
                                    Console.SetCursorPosition(k, j);
                                    Console.WriteLine(salvataggioSchermo[k, j]);
                                }
                            }
                            break;
                    }
                } while (tasto != ConsoleKey.Escape);
        }
    }
}
