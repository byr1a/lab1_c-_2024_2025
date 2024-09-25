using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_c_
{
    public class ConsoleInputHandler : Iuserinput
    {
        public int GetGuess(string text)
        {
            Console.Write("Введите ваше предположение: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
