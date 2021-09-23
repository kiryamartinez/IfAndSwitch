using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, lower, larget;
            int tryCount = 5;
            int userInput;
            Random rnd = new Random();

            number = rnd.Next(0,101);
            lower = rnd.Next(number - 10, number);
            larget = rnd.Next(number + 1, number + 10);

            Console.WriteLine($"Игра рандом угадайте число которе больше {lower} и меньше {larget}");
            Console.WriteLine("Что это за число?");

            while (tryCount-- >0)
            {
                Console.Write("Это число: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput==number)
                {
                    Console.WriteLine("Вы угадали! Ответ верный");
                    break;
                }
                else
                {
                    Console.WriteLine("Ответ не верный попробуйте еще раз!");
                }
            }
            if (tryCount<0)
            {
                Console.WriteLine("Попытки закончились!");
                Console.WriteLine("Вы проирали! Правильный ответ: "+number);
            }
        }
    }
}
