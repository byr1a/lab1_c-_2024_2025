
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessGame;

namespace lab1_c_
{
    internal class Program:Game
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
                Console.WriteLine("Введите 1-выйти, 0-запустить программу");
                string choice = Convert.ToString(Console.ReadLine());


                if (choice == "0")
                {   
                    GameStart();
                    Iuserinput consoleInputHandler = new ConsoleInputHandler();
                }
                if (choice == "1")
                {
                    GameStop();
                    return;
                }

            }


        }
    }
}
