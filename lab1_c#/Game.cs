using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace GuessGame
{//сука
    public class Game
    {   
        public static void GameStart() 
        {
            Console.Write("От ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("До ");
            int b = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random((int)DateTime.Now.Ticks);
            int number = rand.Next(a, b);
            Console.WriteLine("Я загадал число угадай его: ");
            int tries = 0;
            int tmp = int.MinValue;
            while ((tmp = Convert.ToInt32(Console.ReadLine())) != number)
            {
                Console.WriteLine(tmp < number ? "Больше" : "Меньше");
                tries++;
            }
            Console.WriteLine(string.Format("Вы угадали", tries));
        }
        public static void GameStop() 
        {
            return;
        }
    }
}


