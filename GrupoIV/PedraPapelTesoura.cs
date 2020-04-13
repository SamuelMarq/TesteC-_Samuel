using System;
using System.Threading;

namespace GrupoIV
{
    public class PedraPapelTesoura
    {
        private const char ROCK = 'r';
        private const char PAPER = 'p';
        private const char SCISSORS = 's';

        public static void Start()
        {
           
        }

        #region Suporte
        private static void DisplayLoser(string name)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Roses are Red");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("A longboard is also called a cruiser");
            Console.Write("I'm sorry ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(name);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("!\nYou are the loser");
        }

        private static void DisplayTie()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Roses are Red");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("I must say goodbye");
            Console.WriteLine("This game is over!");
            Console.WriteLine("It ended in a tie");
        }
        private static int Aleatorio(int min, int max)
        {
            return new Random().Next(max) + min;
        }

        private static void Display( char p1, char p2, int rounds = 4)
        {
            for (var i = 0; i < rounds; i++)
            {
                var @switch = false;
                var pos = 0;
                while (!(@switch && pos == 0))
                {
                    Console.Clear();
                    if (i == rounds - 1 && pos == 2)
                    {
                        DisplayResult(pos, p1, p2);
                        Thread.Sleep(500);
                        break;
                    }
                    else
                    {
                        DisplayResult(pos, 'r', 'r');
                    }
                    Thread.Sleep(50);
                    pos = pos + (@switch ? -1 : 1);
                    if (pos == 4) @switch = !@switch;
                }
            }
        }

        private static void DisplayWinner(string playerName)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Roses are Red");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Violets are blue");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Congratulations ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor= ConsoleColor.White;
            Console.Write(playerName);
            Console.BackgroundColor= ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("!\nA winner is you");
        }

        private static void DisplayResult(int lines, char p1, char p2)
        {
            while (lines > 0)
            {
                Console.WriteLine();
                lines--;
            }
            //1
            Console.Write("          _______");
            Console.CursorLeft = 30;
            Console.WriteLine(p2 == 'r' ? "  _______" : p2 == 'p' ? "       _______" : "       _______");

            //2
            Console.Write(p1 == 'r' ? "      ---'   ____)" : p1 == 'p' ? "      ---'   ____)____ " : "      ---'   ____)____");
            Console.CursorLeft = 30;
            Console.WriteLine(p2 == 'r' ? " (____   '---      " : p2 == 'p' ? "  ____(____   '---      " : "  ____(____   '---      ");

            //3
            Console.Write(p1 == 'r' ? "            (_____)" : "                ______)");
            Console.CursorLeft = 30;
            Console.WriteLine(p2 == 'r' ? "(____   '---      " : " (______");

            //4
            Console.Write(p1 == 'r' ? "            (_____)" : p1 == 'p' ? "                _______)" : "             __________)");
            Console.CursorLeft = 30;
            Console.WriteLine(p2 == 'r' ? "(_____)" : p2 == 'p' ? "(_______" : "(__________");

            //5
            Console.Write(p1 == 'r' ? "             (____)" : p1 == 'p' ? "               _______)" : "            (____)");
            Console.CursorLeft = 30;
            Console.WriteLine(p2 == 'r' ? "(____)" : p2 == 'p' ? " (_______" : "     (____)");

            //6
            Console.Write(p1 == 'r' ? "      ---.__(___) " : p1 == 'p' ? "      ---.__________)" : "      ---.__(___)");
            Console.CursorLeft = 30;
            Console.WriteLine(p2 == 'r' ? "  (___)__.---" : p2 == 'p' ? "   (__________.---" : "      (___)__.---");
        }

        #endregion

    }
}
