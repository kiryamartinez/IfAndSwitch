using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiators
{
    class Program
    {
        static void Main(string[] args)
        {
            float health1;
            int damage1;
            int armor1;
            float health2;
            int damage2;
            int armor2;

            Random rnd = new Random();

            health1 = rnd.Next(70,100);
            damage1 = rnd.Next(40, 75);
            armor1 = rnd.Next(20,40);
            health2 = rnd.Next(70, 100);
            damage2 = rnd.Next(75, 100);
            armor2 = rnd.Next(40,50);

            Console.WriteLine($"Гладитор 1: {health1} жизней. {damage1} урона. {armor1} брони!");
            Console.WriteLine($"Гладитор 2: {health2} жизней. {damage2} урона. {armor2} брони!");

            while (health1>0 && health2>0)
            {
                health1 -= Convert.ToSingle(damage2) / 100 * armor1;
                health2 -= Convert.ToSingle(damage1) / 100 * armor2;
                Console.WriteLine($"Гладиатор 1 :{health1} жизни!");
                Console.WriteLine($"Гладиатор 2 :{health2} жизни!");
            }
            if (health1<=0 && health2<=0)
            {
                Console.WriteLine("Ничья! Оба мертвы!");
            }
            else if (health1>0)
            {
                Console.WriteLine("Гладиатор 1 победил!!!");
            }
            else if (health2 > 0)
            {
                Console.WriteLine("Гладиатор 2 победил!!!");
            }

        }
    }
}
