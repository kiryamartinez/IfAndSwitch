using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ii
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbol = "$";
            string name = "kirya";
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Введите символ: ");
            symbol=Console.ReadLine();
            Console.Write("Введите имя: ");
            name = Console.ReadLine();

            for (int i=0;i<(name.Length+2);i++)
            {
                Console.Write(symbol);
            }
            
            Console.Write("\n" + symbol);
            Console.Write(name);
            Console.Write(symbol+ "\n");

            for (int i = 0; i < (name.Length + 2); i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine("");
            
        }
    }
}
